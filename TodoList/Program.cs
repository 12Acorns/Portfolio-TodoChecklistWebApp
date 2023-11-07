namespace TodoList
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorPages();

			var app = builder.Build();

			Configure(app);
		}
		private static void Configure(WebApplication _app)
		{
			// Configure the HTTP request pipeline.
			if (!_app.Environment.IsDevelopment())
			{
				_app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				_app.UseHsts();
			}

			_app.UseHttpsRedirection();
			_app.UseStaticFiles();

			_app.UseRouting();

			_app.UseAuthorization();

			_app.MapRazorPages();

			_app.Run();
		}
	}
}