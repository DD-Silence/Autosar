using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosar
{
    public interface IArIdentifier
    {
        IDENTIFIER SHORTNAME { get; set; }
    }

    public interface IArEcucBswmdBase : IArIdentifier
    {
        MULTILANGUAGEOVERVIEWPARAGRAPH DESC { get; set; }
        POSITIVEINTEGERVALUEVARIATIONPOINT LOWERMULTIPLICITY { get; set; }
        POSITIVEINTEGERVALUEVARIATIONPOINT UPPERMULTIPLICITY { get; set; }
        BOOLEANVALUEVARIATIONPOINT UPPERMULTIPLICITYINFINITE { get; set; }
        DOCUMENTATIONBLOCK INTRODUCTION { get; set; }
    }

    public partial class ARPACKAGE : IArIdentifier
    {
    }

    public partial class ECUCMODULEDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCPARAMCONFCONTAINERDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCCHOICECONTAINERDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCENUMERATIONPARAMDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCINTEGERPARAMDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCBOOLEANPARAMDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCFLOATPARAMDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCSTRINGPARAMDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCFUNCTIONNAMEDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCREFERENCEDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCFOREIGNREFERENCEDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCSYMBOLICNAMEREFERENCEDEF : IArEcucBswmdBase
    {
    }

    public partial class ECUCCHOICEREFERENCEDEF : IArEcucBswmdBase
    {
    }
}
