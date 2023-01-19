//EntityType AutoGenerated by tool
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using DataOperations.OData; 
using DataOperations; 

namespace GWSAMPLE_BASIC
{

    public class VH_Sex : BaseDTOWithIDAndETag
    {
        private string _Sex;
        public string Sex 
        { 
            get {
                return _Sex;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Sex cannot be null and must have a value.");
                }
                if(value.Length > 1)
                {
                    throw new ValidationException("Sex cannot be longer than 1 characters.");
                }
                else
                {
                    _Sex = value;
                }
            }
        }
        private string _Shorttext;
        public string Shorttext 
        { 
            get {
                return _Shorttext;
            }
            set {
                if(value == null)
                {
                    throw new ValidationException("Shorttext cannot be null and must have a value.");
                }
                if(value.Length > 60)
                {
                    throw new ValidationException("Shorttext cannot be longer than 60 characters.");
                }
                else
                {
                    _Shorttext = value;
                }
            }
        }
        protected override Dictionary<string, List<string>> ReferenceKeys 
        {   
            get 
            {
                var result = new Dictionary<string, List<string>>();
                result.Add("PrimaryKey", new List<string>() {"Sex"});

                return result;
            }
        }


    }
}