﻿//-----------------------------------------------------------------------
// <copyright file="SortieParSemaineRepository.cs" company="Jawhar">
//      Copyright ( c ) Jawhar. All rights reserved.
// </copyright>
// <summary>This is the Context class.</summary>
//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Excursion.Data;
using Excursion.Business;


namespace Excursion.Business.Repositories
{
    #region directives


    #endregion
    /// <summary>
    /// this is a SortieParSemaineRepository class
    /// </summary>
    public class SortieParSemaineRepository : RepositoryBase<Excursion.Data.SortieParSemaine>
    {
        #region Fields

        ///<summary>
        ///le dbSet des entités de type SortieParSemaine
        ///</summary>
        public DbSet<Excursion.Data.SortieParSemaine> BoxSet;

        #endregion Fields

        #region Ctors

        ///<summary>
        ///Le constructeur du SortieParSemaineRepository
        ///</summary>
        ///<param name="contextParam">Le context de la base de donnée.</param>
        public SortieParSemaineRepository(ExcursionContext contextParam)
        {
            this.context = contextParam;
            this.BoxSet = context.SortieParSemaineSet;
        }

        #endregion Ctors

        #region Methods

        /// <summary>
        /// Création d'une nouvelle instance de type SortieParSemaine.
        /// </summary>
        public override Excursion.Data.SortieParSemaine Create()
        {
            return new Excursion.Data.SortieParSemaine();
        }

        /// <summary>
        /// Ajout de l'entité specifiée au respository de type SortieParSemaine.
        /// </summary>
        /// <param name="entity">l'entité à ajouter.</param>
        public override void Add(Excursion.Data.SortieParSemaine entity)
        {
            BoxSet.Add(entity);
        }

        /// <summary>
        /// Modification de l'entité specifiée
        /// </summary>
        /// <param name="entity">L'entité à modifier.</param>
        public override void Update(Excursion.Data.SortieParSemaine entity)
        {
            BoxSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        ///Suppression de l'entité avec id = @id.
        /// </summary>
        /// <param name="id">id de l'entité à supprimer.</param>
        public override void Delete(int id)
        {
            Excursion.Data.SortieParSemaine entityToDelete = BoxSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// Suppression de l'entité specifiée. 
        /// </summary>
        /// <param name="entity">l'entité à supprimer.</param>
        public override void Delete(Excursion.Data.SortieParSemaine entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                BoxSet.Attach(entityToDelete);
            }
            BoxSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Avoir l'entité avec id= @id .
        /// </summary>
        /// <param name="id">l'id de l'entité voulu.</param>
        /// <returns></returns>
        public override Excursion.Data.SortieParSemaine GetById(int id)
        {
            return BoxSet.Find(id);
        }


        /// <summary>
        /// Avoir une IQueryable sequence des entités de type SortieParSemaine.
        /// </summary>
        /// <returns></returns>
        public override IQueryable<Excursion.Data.SortieParSemaine> GetAllAsQueryable()
        {
            return BoxSet;
        }

        /// <summary>
        /// Avoir une IEnumerable sequence des entités de type SortieParSemaine.
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Excursion.Data.SortieParSemaine> GetAll()
        {
            return BoxSet.ToList();
        }

        /// <summary>
        /// Avoir une IEnumerable sequence des entités de type SortieParSemaine filtered on the @where predicate.
        /// </summary>
        /// <param name="where">Le prédicat where.</param>
        /// <returns></returns>
        public override IEnumerable<Excursion.Data.SortieParSemaine> FindMany(Expression<Func<Excursion.Data.SortieParSemaine, bool>> where)
        {
            return BoxSet.Where(where);
        }

        /// <summary>
        /// Avoir une seule entité depuis une séquence des entités de type SortieParSemaine en filtrant avec le prédicat @where .
        /// </summary>
        /// <param name="where">Le prédicat where.</param>
        /// <returns></returns>
        public override Excursion.Data.SortieParSemaine FindOne(Expression<Func<Excursion.Data.SortieParSemaine, bool>> where)
        {
            return BoxSet.FirstOrDefault(where);
        }

        /// <summary>
        /// Sauvegarder dans le context les changements
        /// </summary>
        public override void Save()
        {
            context.SaveChanges();
        }
        #endregion Methods


    }
}


