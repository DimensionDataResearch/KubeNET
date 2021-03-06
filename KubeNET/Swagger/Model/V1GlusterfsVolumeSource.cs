using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// Represents a Glusterfs mount that lasts the lifetime of a pod. Glusterfs volumes do not support ownership management or SELinux relabeling.
  /// </summary>
  [DataContract]
  public class V1GlusterfsVolumeSource {
    
    /// <summary>
    /// EndpointsName is the endpoint name that details Glusterfs topology. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md#create-a-pod
    /// </summary>
    /// <value>EndpointsName is the endpoint name that details Glusterfs topology. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md#create-a-pod</value>
    [DataMember(Name="endpoints", EmitDefaultValue=false)]
    public string Endpoints { get; set; }

    
    /// <summary>
    /// Path is the Glusterfs volume path. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md#create-a-pod
    /// </summary>
    /// <value>Path is the Glusterfs volume path. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md#create-a-pod</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    public string Path { get; set; }

    
    /// <summary>
    /// ReadOnly here will force the Glusterfs volume to be mounted with read-only permissions. Defaults to false. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md#create-a-pod
    /// </summary>
    /// <value>ReadOnly here will force the Glusterfs volume to be mounted with read-only permissions. Defaults to false. More info: http://releases.k8s.io/HEAD/examples/glusterfs/README.md#create-a-pod</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    public bool? ReadOnly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1GlusterfsVolumeSource {\n");
      
      sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
      
      sb.Append("  Path: ").Append(Path).Append("\n");
      
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
      
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
