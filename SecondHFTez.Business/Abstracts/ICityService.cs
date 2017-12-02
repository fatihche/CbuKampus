using System.Collections.Generic;
using SecondHFTez.Entities.Concrete;

namespace SecondHFTez.Business.Abstracts
{
    public interface ICityService
    {
        //List<City> GetList();
        City Get(int id);
        City GetWithPostCode(int code);
        City GetWithName(string name);
        //bu ikisine gerek olmaz


    }
}