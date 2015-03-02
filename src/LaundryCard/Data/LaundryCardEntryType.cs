using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace LaundryCard
{
  [DataContract(Name = "LaundryCardEntryType", Namespace = SaveFile.Namespace)]
  public enum LaundryCardEntryType
  {
    [EnumMember]
    Deposit,
    [EnumMember]
    Dryer,
    [EnumMember]
    Washer,
    [EnumMember]
    Withdrawal,
  }
}
