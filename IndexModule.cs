using Nancy.Json;
using Nancy.ModelBinding;

namespace ModelListBinding
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            Post["/new"] = _ =>
            {
                var model = this.Bind<Model>();
                return new JavaScriptSerializer().Serialize(model);
            };
        }
    }

    public class Model
    {
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string[] List { get; set; }
        
        
    }
}