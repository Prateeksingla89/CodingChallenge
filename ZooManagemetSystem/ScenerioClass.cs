using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooManagemetSystem.ViewModel;

namespace ZooManagemetSystem
{
    public class ScenerioClass
    {
        private readonly ZooContext context;
        public ScenerioClass(ZooContext context)
        {
            this.context = context;
        }

        //Scenerio animal status

        public void AnimalAtHomeZoom()
        {

            var result = (from zooAnimal in context.ZooAnimalMappingModels
                          join zoo in context.ZooModels on zooAnimal.ZooId equals zoo.ZooId
                          where zooAnimal.IsActive == true && zoo.ZooName == "Home"
                          select new AnimalHomeViewModel
                          {
                              ZooId = zoo.ZooId,
                              AnimalName = zooAnimal.AnimalModel.AnimalName
                          }).ToList();
        }

        //Scenerio animal catwise Dont get much time to write all scenerios but i am sure we can handle each one by using entity
        public void AnimalCatgoryWise()
        {

            var result = (from zooAnimal in context.AnimalModels
                          group zooAnimal by zooAnimal.AnimalCatgId into g

                          select new AnimalCategory
                          {
                              CategoryId = g.Key,
                          });
        }
    }
}
