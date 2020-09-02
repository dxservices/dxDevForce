using ServiceStack;

namespace devBuilder.ServiceModel
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseResponse
    {
        public BaseResponse()
        {
            IsSuccess = true;
        }
        public bool IsSuccess { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual ResponseStatus ResponseStatus { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseResponse<T>: BaseResponse
    {
        public T Data { get; set; }
    }
}