﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using SeminarMicroservice.DTO;
using Microsoft.IdentityModel.Tokens;

namespace SeminarMicroservice.Helper
{
    public static class JWTHelper
    {
        public static TokenModel GenerateJwtToken(string userName, string accountId, int role)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Name, accountId),
                new Claim(ClaimTypes.Role, role.ToString())
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTToken.JwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(JWTToken.JwtExpireDays));

            var tokenProperties = new JwtSecurityToken(
                JWTToken.JwtIssuer,
                JWTToken.JwtAudienceId,
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new TokenModel(new JwtSecurityTokenHandler().WriteToken(tokenProperties), tokenProperties, role);
        }

        public static TokenModel GenerateJwtTokenWithTime(string userName, string accountId, int role, DateTime expires, bool FirstChangeProfile, Guid? PriceListId)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, userName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Name, accountId),
                new Claim(ClaimTypes.Role, role.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTToken.JwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenProperties = new JwtSecurityToken(
                JWTToken.JwtIssuer,
                JWTToken.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: creds
            );

            return new TokenModel(new JwtSecurityTokenHandler().WriteToken(tokenProperties), tokenProperties, role);
        }
    }
}
