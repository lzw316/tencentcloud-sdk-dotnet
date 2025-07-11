/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Region.V20220627.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// 可用区名称，例如，ap-guangzhou-3
        /// 全网可用区名称如下：
        /// <li> ap-chongqing-1 </li>
        /// <li> ap-seoul-1 </li>
        /// <li> ap-seoul-2 </li>
        /// <li> ap-chengdu-1 </li>
        /// <li> ap-chengdu-2 </li>
        /// <li> ap-hongkong-1 </li>
        /// <li> ap-hongkong-2 </li>
        /// <li> ap-shenzhen-fsi-1 </li>
        /// <li> ap-shenzhen-fsi-2 </li>
        /// <li> ap-shenzhen-fsi-3 </li>
        /// <li> ap-guangzhou-1（售罄）</li>
        /// <li> ap-guangzhou-2（售罄）</li>
        /// <li> ap-guangzhou-3 </li>
        /// <li> ap-guangzhou-4 </li>
        /// <li> ap-guangzhou-6 </li>
        /// <li> ap-tokyo-1 </li>
        /// <li> ap-singapore-1 </li>
        /// <li> ap-singapore-2 </li>
        /// <li> ap-shanghai-fsi-1 </li>
        /// <li> ap-shanghai-fsi-2 </li>
        /// <li> ap-shanghai-fsi-3 </li>
        /// <li> ap-bangkok-1 </li>
        /// <li> ap-shanghai-1（售罄） </li>
        /// <li> ap-shanghai-2 </li>
        /// <li> ap-shanghai-3 </li>
        /// <li> ap-shanghai-4 </li>
        /// <li> ap-shanghai-5 </li>
        /// <li> ap-mumbai-1 </li>
        /// <li> ap-mumbai-2 </li>
        /// <li> ap-beijing-1 </li>
        /// <li> ap-beijing-2 </li>
        /// <li> ap-beijing-3 </li>
        /// <li> ap-beijing-4 </li>
        /// <li> ap-beijing-5 </li>
        /// <li> na-siliconvalley-1 </li>
        /// <li> na-siliconvalley-2 </li>
        /// <li> eu-frankfurt-1 </li>
        /// <li> na-ashburn-1 </li>
        /// <li> na-ashburn-2 </li>
        /// <li> ap-nanjing-1 </li>
        /// <li> ap-nanjing-2 </li>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 可用区描述，例如，广州三区
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 可用区ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 可用区状态，包含AVAILABLE和UNAVAILABLE。AVAILABLE代表可用，UNAVAILABLE代表不可用。
        /// </summary>
        [JsonProperty("ZoneState")]
        public string ZoneState{ get; set; }

        /// <summary>
        /// 父级zone
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentZone")]
        public string ParentZone{ get; set; }

        /// <summary>
        /// 父级可用区ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentZoneId")]
        public string ParentZoneId{ get; set; }

        /// <summary>
        /// 父级可用区描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentZoneName")]
        public string ParentZoneName{ get; set; }

        /// <summary>
        /// zone类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneType")]
        public string ZoneType{ get; set; }

        /// <summary>
        /// 控制台类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MachineRoomTypeMC")]
        public string MachineRoomTypeMC{ get; set; }

        /// <summary>
        /// 和ZoneId一样，适用于控制台调用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ZoneIdMC")]
        public string ZoneIdMC{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneState", this.ZoneState);
            this.SetParamSimple(map, prefix + "ParentZone", this.ParentZone);
            this.SetParamSimple(map, prefix + "ParentZoneId", this.ParentZoneId);
            this.SetParamSimple(map, prefix + "ParentZoneName", this.ParentZoneName);
            this.SetParamSimple(map, prefix + "ZoneType", this.ZoneType);
            this.SetParamSimple(map, prefix + "MachineRoomTypeMC", this.MachineRoomTypeMC);
            this.SetParamSimple(map, prefix + "ZoneIdMC", this.ZoneIdMC);
        }
    }
}

