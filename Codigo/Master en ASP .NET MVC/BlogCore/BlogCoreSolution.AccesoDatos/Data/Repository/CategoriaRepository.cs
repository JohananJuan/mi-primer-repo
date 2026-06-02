//using BlogCoreSolution.AccesoDatos.Data.Repository.IRepository;
//using BlogCoreSolution.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Runtime.CompilerServices;
//using System.Text;

//namespace BlogCoreSolution.AccesoDatos.Data.Repository
//{
//    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
//    {
//        private readonly ApplicationDbContext _db;


//        public void Update(Categoria categoria)
//        {
//            var objDesdeDb = _db.Categorias.FirstOrDefault(s => s.id == categoria.id);
//    }
//}
