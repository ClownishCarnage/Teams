namespace ClownishCarnage.TeamsSSO.Mvc
{
    public static class SetupAuthenticationServices
    {
        public static WebApplicationBuilder AuthenticationServices(this WebApplicationBuilder builder)
        {

            builder.Services.AddAuthorization();
            return builder;
        }

    }
}
