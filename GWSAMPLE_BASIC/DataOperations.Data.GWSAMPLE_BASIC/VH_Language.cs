//EntityType AutoGenerated by tool
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace GWSAMPLE_BASIC
{

    public class VH_Language : BaseDTOWithIDAndETag
    {
        private string _Spras;
        public string Spras 
        { 
            get {
                return _Spras;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Spras cannot be null and must have a value.");
                }
                if(value.Length > 2)
                {
                    throw new ValidationException("Spras cannot be longer than 2 characters.");
                }
                else
                {
                    _Spras = value;
                }
            }
        }
        private string _Sptxt;
        public string Sptxt 
        { 
            get {
                return _Sptxt;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Sptxt cannot be null and must have a value.");
                }
                if(value.Length > 16)
                {
                    throw new ValidationException("Sptxt cannot be longer than 16 characters.");
                }
                else
                {
                    _Sptxt = value;
                }
            }
        }
        protected override Dictionary<string, List<string>> ReferenceKeys 
        {   
            get 
            {
                var result = new Dictionary<string, List<string>>();
                result.Add("PrimaryKey", new List<string>() {"Spras"});

                return result;
            }
        }


    }
}