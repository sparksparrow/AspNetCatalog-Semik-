using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models;
using GnomShop.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GnomShop.Domain.Repositories.EF
{
    public class EFProductItemRepository : IProductItemRepository
    {
        private readonly CatalogDbContext context;
        public EFProductItemRepository(CatalogDbContext context)
        {
            this.context = context;
        }

        public IQueryable<ProductItem> GetProducts()
        {
            return context.ProductItems.Include(product => product.Sizes).Include(product => product.Images);
        }

        public ProductItem GetProductById(Guid id)
        {
            ProductItem entity = context.ProductItems.FirstOrDefault(x => x.Id == id);
            context.Entry(entity).Collection(product => product.Sizes).Load();
            context.Entry(entity).Collection(product => product.Images).Load();
            return entity;
        }

        public void SaveProductItem(ProductItem entity)
        {
            if (entity.Id == default)
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
                foreach (Image img in entity.Images)
                {
                    context.Entry(img).State = EntityState.Added;
                }
                foreach (Size size in entity.Sizes)
                {
                    context.Entry(size).State = EntityState.Added;
                }
            }
            else
            {     
                foreach (Image img in entity.Images)
                {
                    context.Entry(img).State = EntityState.Added;
                }                           

                var dbSizes = context.Sizes.Where(size => size.ProductItemId == entity.Id);
                if (!entity.Sizes.SequenceEqual(dbSizes.ToList()))
                {
                    context.Sizes.RemoveRange(dbSizes);
                    context.SaveChanges();
                    foreach (Size size in entity.Sizes)
                    {
                        context.Entry(size).State = EntityState.Added;
                    }
                }

                context.Entry(entity).State = EntityState.Modified;                
                context.SaveChanges();                              
            }
            if (entity.Images.Any())
            {
                FileSystemApi.CopyTempDirectoryById(context.Entry(entity).Entity.Id);
            }
            context.SaveChanges();
        }

        public void DeleteProduct(Guid id)
        {
            ProductItem entity = context.ProductItems.FirstOrDefault(obj => obj.Id == id);
            if(entity != default)
            {
                context.Entry(entity).State = EntityState.Deleted; 
                FileSystemApi.DeleteImagesDirectoryById(context.Entry(entity).Entity.Id);                
                context.SaveChanges();
            } 
        }
    }
}

