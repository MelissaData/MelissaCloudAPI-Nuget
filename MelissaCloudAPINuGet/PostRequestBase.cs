using System.Collections.Generic;

namespace MelissaData.CloudAPI
{
    public abstract class PostRequestBase<TRecord>
    {
        public string TransmissionReference { get; set; }

        public string Options { get; set; }
        public List<TRecord> Records { get; set; }
    }
}
