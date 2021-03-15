using System;
using System.Reflection;

namespace nguyenQuangPhuoc_5951071080.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}