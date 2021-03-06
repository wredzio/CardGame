﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardGameApp.Servicies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using CardGameApp.Utils;
using CardGameApp.Areas.Boards.Models;
using CardGameApp.Areas.Boards.ViewModels;
using CardGameApp.Areas.Boards.Mappers;
using CardGameApp.Areas.Decks.Mappers;
using CardGameApp.Areas.Decks.ViewModels;
using CardGameApp.Areas.Decks.Models;

namespace CardGameApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Game>();
            services.AddScoped<IMapper<Board, BoardViewModel>, BoardMapper>();
            services.AddScoped<IMapper<Deck, DeckViewModel>, DeckMapper>();
            services.AddScoped<IDrawer, Drawer>();
            services.AddScoped<ISorter, Sorter>();
            services.AddScoped<IShuffler, Shuffler>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
