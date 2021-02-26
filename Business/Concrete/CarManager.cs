using Business.Abstract;
using Business.Concrete.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Descriptions.Length > 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            else
            {
                return new ErrorResult(Messages.CarDailyPriceInvalid);
            }
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            // if (DateTime.Now.Hour == 10)
            //{
            //    return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<Car>> ( _carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
