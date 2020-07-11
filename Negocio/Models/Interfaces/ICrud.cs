using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Models.Interfaces
{
    public interface ICloseInt<T>
    {
        void Init();
        T GetOne(int id);
        List<T> GetAll();
    }
    public interface ICloseString<T>
    {
        void Init();
        T GetOne(String id);
        List<T> GetAll();
    }

    public interface IOpenInt<T>
    {
        void Init();
        bool Create();
        T GetOne(int id);
        List<T> GetAll();
        bool Update(int id);
        bool Delete(int id);
        bool Delete(T m);
    }

    public interface IOpenString<T>
    {
        void Init();
        bool Create();
        T GetOne(string id);
        List<T> GetAll();
        bool Update(string id);
        bool Delete(string id);
        bool Delete(T m);
    }
}
