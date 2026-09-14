using Arac.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AracKiralama.Persistance.Context
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=emre;Database=CarBook;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands  { get; set; }
        public DbSet<Car> Cars  { get; set; }
        public DbSet<CarDesc> CarDescriptions  { get; set; }
        public DbSet<CarFeature> CarFeatures  { get; set; }
        public DbSet<CarPricing> CarPricings  { get; set; }
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Contact> Contacts  { get; set; }
        public DbSet<Feature> Features  { get; set; }
        public DbSet<FooterAddresses> FooterAddresses  { get; set; }
        public DbSet<Location> Locations  { get; set; }
        public DbSet<Pricing> Pricings  { get; set; }
        public DbSet<Service> Services  { get; set; }
        public DbSet<SocialMedia> SocialMedias  { get; set; }
        public DbSet<Testimonial> Testimonials  { get; set; }

    }

}