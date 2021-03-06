using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
namespace TeleSharp.TL
{
    [TLObject(319588707)]
    public class TLPageBlockSlideshow : TLAbsPageBlock
    {
        public override int Constructor
        {
            get
            {
                return 319588707;
            }
        }

        public TLVector<TLAbsPageBlock> items { get; set; }
        public TLAbsRichText caption { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            items = (TLVector<TLAbsPageBlock>)ObjectUtils.DeserializeVector<TLAbsPageBlock>(br);
            caption = (TLAbsRichText)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(items, bw);
            ObjectUtils.SerializeObject(caption, bw);

        }
    }
}
