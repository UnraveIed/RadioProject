using RadioProject.Business.Abstract;
using RadioProject.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;
using RadioProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RadioProject.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var radioService = InstanceFactory.Get<IRadioService>();
            var postService = InstanceFactory.Get<IPostService>();
            postService.Add(new Post()
            {
                PostId = 0,
                Title = "Ado Deneme",
                Details = "Ado Deneme"
            });
            //radioService.Update(new Radio
            //{
            //    RadioId = 1,
            //    Name = "Ferhat",
            //    Frequency = 999.2,
            //    isOnline = false
            //});
            //var list = new List<Radio>
            //{
            //    new Radio(){RadioId=0,Name="Deneme1",Frequency=91.2,isOnline=true},
            //    new Radio(){RadioId=0,Name="fqefcqf",Frequency=91.2,isOnline=true},
            //    new Radio(){RadioId=0,Name="ghreıgfeqefef",Frequency=91.2,isOnline=true}

            //};
            //foreach (var item in list)
            //{
            //    radioService.Add(item);
            //}
           
            //    radioService.Delete(new Radio() { RadioId = radioService.GetAll().Count-2 });
           
            var liste = radioService.GetAll();
            var list = postService.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
