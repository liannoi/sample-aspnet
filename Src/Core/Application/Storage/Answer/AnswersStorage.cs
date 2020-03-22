using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Infrastructure.Application.Core.BusinessServices;
using SampleAspNet.Application.Entities;
using SampleAspNet.Domain.Exceptions;

namespace SampleAspNet.Application.Storage.Answer
{
    public static class AnswersStorage
    {
        public static IEnumerable<AnswerDto> FindSafe(this IBusinessService<AnswerDto> self,
            Expression<Func<AnswerDto, bool>> expression)
        {
            var result = self.Find(expression);
            return !result.Any() ? throw new EntityByPredicateNotFoundException() : result;
        }
    }
}