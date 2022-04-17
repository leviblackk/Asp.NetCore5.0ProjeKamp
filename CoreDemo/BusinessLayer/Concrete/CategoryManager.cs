using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository eFCategoryRepository;

        public CategoryManager()
        {
            eFCategoryRepository = new EFCategoryRepository();

        }

        //Business Katmanında  Abstract Klasörü içinde  Yer Alan interFaceler: Service olarak adlandırılmıştır
        //Business Katmanında Concrete Klasörü içinde Yer Alan Sınıflar: Manager olarak adlandırılmıştır
        public void CategoryAdd(Category category)
        {
            eFCategoryRepository.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
            eFCategoryRepository.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            eFCategoryRepository.Update(category);
        }

        public Category GetByID(int id)
        {
            return
            eFCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
            return eFCategoryRepository.GetListAll();
        }
    }
}
