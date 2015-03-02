using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LaundryCard
{
  [DataContract(Name = "ApplicationSettings", Namespace = SaveFile.Namespace)]
  public class ApplicationSettings : IExtensibleDataObject
  {
    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    [DataMember]
    public decimal WasherCost { get; set; }
    [DataMember]
    public decimal DryerCost { get; set; }
    [DataMember]
    public bool EnableQuickEntry { get; set; }
    [DataMember]
    public int DefaultQuantity { get; set; }
  }
}
