using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;

namespace JDWeb.Common
{
    public static class MEFManager
    {
        public static void Compose(object o)
        {
            var container = new CompositionContainer(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin")));
            var batch = new CompositionBatch();

            batch.AddPart(o);
            container.Compose(batch);
        }
    }
}
