namespace atmservice.Application.Extention
{
    public static class AppMiddelWareExtention
    {
        public static IApplicationBuilder InjectEnvoirmentExtention(this IApplicationBuilder app , IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            return app;
        }

    }
}