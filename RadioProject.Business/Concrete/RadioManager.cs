using RadioProject.Business.Abstract;
using RadioProject.DataAccess.Abstract;
using RadioProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RadioProject.Business.Concrete
{
    public class RadioManager : IRadioService
    {
        IRadioDal _radioDal;

        public RadioManager(IRadioDal radioDal)
        {
            _radioDal = radioDal;
        }

        public void Add(Radio entity)
        {
            _radioDal.Add(entity);
        }

        public void Delete(Radio entity)
        {
            _radioDal.Delete(entity);
        }

        public Radio Get(Expression<Func<Radio, bool>> filter)
        {
            return _radioDal.Get(filter);
        }

        public List<Radio> GetAll(Expression<Func<Radio, bool>> filter = null)
        {
            return _radioDal.GetAll(filter);
        }

        public void Update(Radio entity)
        {
            _radioDal.Update(entity);
        }
    }
}
