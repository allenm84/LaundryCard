using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LaundryCard
{
  [DataContract(Name = "LaundryCardEntry", Namespace = SaveFile.Namespace)]
  public class LaundryCardEntry : IExtensibleDataObject
  {
    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public DateTime Date { get; set; }
    [DataMember]
    public LaundryCardEntryType Type { get; set; }
    [DataMember]
    public decimal Amount { get; set; }
    [DataMember]
    public string Notes { get; set; }
  }
}
