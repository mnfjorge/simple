﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample.Project.Generator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Templates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Templates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sample.Project.Generator.Templates", typeof(Templates).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using Simple.Reflection;
        ///using Simple.Entities;
        ///using ${namespace}.Services;
        ///
        ///namespace ${namespace}.Domain
        ///{
        ///    [Serializable]
        ///    public partial class $classname : Entity&lt;${classname}, I${classname}Service&gt;
        ///    {
        ///#foreach($field in $table.PrimaryKeysExceptFk)
        ///        public virtual $re.TypeFor($field) $re.NameFor($field) { get; set; } 
        ///#end
        ///
        ///#foreach($field in $table.OrdinaryFields)
        ///        public virt [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string EntityGenerator {
            get {
                return ResourceManager.GetString("EntityGenerator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using Simple.Reflection;
        ///using Simple.Entities;
        ///using ${namespace}.Services;
        ///
        ///namespace ${namespace}.Domain
        ///{
        ///    [Serializable]
        ///    public partial class $classname : Entity&lt;${classname}, I${classname}Service&gt;
        ///    {
        ///#foreach($field in $table.PrimaryKeysExceptFk)
        ///        public virtual $re.TypeFor($field) $re.NameFor($field) { get; set; } 
        ///#end
        ///
        ///#foreach($field in $table.OrdinaryFields)
        ///        public virt [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MappingGenerator {
            get {
                return ResourceManager.GetString("MappingGenerator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using Simple.Migrator.Framework;
        ///using Simple.Migrator.Fluent;
        ///using System.Data;
        ///
        ///namespace ${namespace}.Tools.Migrations
        ///{
        ///    [Migration(${timestamp})]
        ///    public class Migration${timestamp} : FluentMigration
        ///    {
        ///        public override void Up()
        ///        {
        ///        }
        ///
        ///        public override void Down()
        ///        {
        ///        }
        ///    }
        ///
        ///}.
        /// </summary>
        internal static string NewMigrationGenerator {
            get {
                return ResourceManager.GetString("NewMigrationGenerator", resourceCulture);
            }
        }
    }
}
