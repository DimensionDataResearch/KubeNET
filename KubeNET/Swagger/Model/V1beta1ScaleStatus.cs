using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// represents the current status of a scale subresource.
  /// </summary>
  [DataContract]
  public class V1beta1ScaleStatus {
    
    /// <summary>
    /// actual number of observed instances of the scaled object.
    /// </summary>
    /// <value>actual number of observed instances of the scaled object.</value>
    [DataMember(Name="replicas", EmitDefaultValue=false)]
    public int? Replicas { get; set; }

    
    /// <summary>
    /// label query over pods that should match the replicas count. More info: http://releases.k8s.io/HEAD/docs/user-guide/labels.md#label-selectors
    /// </summary>
    /// <value>label query over pods that should match the replicas count. More info: http://releases.k8s.io/HEAD/docs/user-guide/labels.md#label-selectors</value>
    [DataMember(Name="selector", EmitDefaultValue=false)]
    public Dictionary<string, string> Selector { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1beta1ScaleStatus {\n");
      
      sb.Append("  Replicas: ").Append(Replicas).Append("\n");
      
      sb.Append("  Selector: ").Append(Selector).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
