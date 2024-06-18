namespace App.Modules.Base.Substrate.tmp.Attributes
{
    /// <summary>
    /// Attribute applied to Entities, DTOs, Controllers that
    /// only exist for demonstrating system.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class ForDemoOnlyAttribute : Attribute { }
}