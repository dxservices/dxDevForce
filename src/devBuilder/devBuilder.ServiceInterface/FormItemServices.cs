using devBuilder.ServiceModel;
using devBuilder.ServiceModel.DataModel;
using devBuilder.ServiceModel.Form;
using ServiceStack;
using ServiceStack.OrmLite;

namespace devBuilder.ServiceInterface
{
    /// <summary>
    /// 
    /// </summary>
    public class FormItemServices:Service
    {
        public PostFormItemResponse Any(CreateFormItemRequest request)
        {
            Db.Insert(request.Entity);
            return new  PostFormItemResponse();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UpdateFormItemResponse Any(UpdateFormItemRequest request)
        {
            Db.Update<FormItem>(request.UpdateFields);
            return new  UpdateFormItemResponse();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse Any(DeleteFormItemRequest request)
        {
            Db.Delete<FormItem>(request.Id);
            return new  BaseResponse();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public FormItemResponse Any(GetFormItemRequest request)
        {
            var response= new  FormItemResponse();
            response.Data = Db.Single<FormItem>(request.Id);
            return response;
        }
    }
}