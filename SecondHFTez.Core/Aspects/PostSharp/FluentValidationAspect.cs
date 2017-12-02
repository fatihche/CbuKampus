using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PostSharp.Aspects;
using SecondHFTez.Core.CrossCuttingConcerns.Validation.FluentValidation;

namespace SecondHFTez.Core.Aspects.PostSharp
{
    [Serializable]
    public class FluentValidationAspect:OnMethodBoundaryAspect
    {
        private Type _validationType;

        public FluentValidationAspect(Type validationType)
        {
            _validationType = validationType;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validationType);//Ivalidator tipinde bir instance yarattık.
            var entityType = _validationType.BaseType.GetGenericArguments()[0];//Validatior aracımızın AbstractValidator<x> gereneric metondundaki X classa ulaştık.//getgenericargument array döner.
            var entities = args.Arguments.Where(e => e.GetType() == entityType);//Hedef metodun parametrelerinden entityType olanları entities lere ekle

            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidate(validator,entity);
            }
        }
    }
}
