using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using JordyP1_Apl.DAL;
using JordyP1_Apl.Entidades;

namespace JordyP1_Apl.BLL{

    public class CiudadesBLL{

        public static bool Guardar(Ciudades ciudades){
            
            if(!Existe(ciudades.CiudadesId))
                return Insertar(ciudades);
            
            else
                return Modificar(ciudades);
        }

        private static bool Insertar(Ciudades ciudades){
            
            bool paso =false;
            Contexto contexto = new Contexto();

            try{
                contexto.Ciudades.Add(ciudades);
                paso = contexto.SaveChanges()>0;

            }
            catch(Exception){
                throw;

            }
            finally{
                contexto.Dispose();

            }

            return paso;
        }

        private static bool Modificar(Ciudades ciudades){
            
            bool paso = false;
            Contexto contexto = new Contexto();

            try{

                contexto.Entry(ciudades).State = EntityState.Modified;
                paso = contexto.SaveChanges()>0;

            }
            catch(Exception){
                throw;

            }
            finally{
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id){

            bool paso = false;
            Contexto contexto = new Contexto();

            try{
                var ciudades = contexto.Ciudades.Find(id);

                if(ciudades != null){
                    contexto.Ciudades.Remove(ciudades);
                    paso = contexto.SaveChanges()>0;
                }

            }
            catch(Exception){
                throw;

            }
            finally{
                contexto.Dispose();
            }

            return paso;
        }

        
    }
}