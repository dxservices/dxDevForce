using System;
using ServiceStack;
using devBuilder.ServiceModel;
using devBuilder.ServiceModel.DataModel;
using devBuilder.ServiceModel.Form;
using ServiceStack.OrmLite;

namespace devBuilder.ServiceInterface
{
    /// <summary>
    /// 
    /// </summary>
    public class FormServices : Service
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public PostFormResponse Any(CreateFormRequest request)
        {
            Db.Insert(request.Entity);
            return new  PostFormResponse();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateFormResponse Any(UpdateFormRequest request)
        {
            Db.Update<Form>(request.UpdateFields);
            return new  UpdateFormResponse();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse Any(DeleteFormRequest request)
        {
            Db.Delete<Form>(request.Id);
            return new  BaseResponse();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public FormResponse Any(GetFormRequest request)
        {
            var response= new  FormResponse();
            response.Data = Db.Single<Form>(request.Id);
            return response;
        }
    }
}
