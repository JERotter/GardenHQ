using System;
namespace GardenHQ.Common.Authentication;

public class JwtConfig
{
	public string Issuer { get; set; }

	public string Audience { get; set; }

	public string Secret { get; set; }
}
