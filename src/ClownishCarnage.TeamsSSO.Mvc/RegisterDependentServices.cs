namespace ClownishCarnage.TeamsSSO.Mvc
{
    public static class RegisterDependentServices
    {
        /// <summary>
        /// Register Dependencies. 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services
            .AddHttpContextAccessor()            
                .AddSession() 
                .AddMvc();

            return builder;
        }
    }
}