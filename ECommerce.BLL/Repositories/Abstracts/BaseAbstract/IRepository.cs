using ECommerce.Model.Base;

namespace ECommerce.BLL.Repositories.Abstracts.BaseAbstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        //IEnumerable: içerisinde barındırıların listeyi ve istenildiği zaman o liste içerisinde de ayrı bir listeyi barındıran özelleştirilmiş bir interface. İçerisinde barındırmış olduğu liste elemanını döngüye ihtiyaç duymadan geriye döndürülmesi sağlar.

        //List: İçerisinde tekil değerler barındırır. Döngüye ihtiyaç duyar

       


        //List
        IEnumerable<T> GetAll();
       

        //Get
        T GetById(int id);

        //Active
        IEnumerable<T> GetActives();


        //Passive
        IEnumerable<T> GetPassives();

        //Destroy
        Task<string> DestroyData(T entity);

        //Create
        Task<string> Create(T entity);  
        

        //Update
        Task<string> Update(T entity);

        //Delete
        Task<string> Delete(T entity);




    }
}
