namespace atmservice.Application.Extention
{
    public static class AppServiceExtention
    {
        public static IServiceCollection InjectServices(this IServiceCollection service)
        {
            // Add services to the container.
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            service.AddEndpointsApiExplorer();
            service.AddSwaggerGen();


            return service;

        }

    }
}