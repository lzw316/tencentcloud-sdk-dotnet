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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessKeyAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Access Key字段配置</p>
        /// </summary>
        [JsonProperty("ParamList")]
        public AccessKeyParamConfig[] ParamList{ get; set; }

        /// <summary>
        /// <p>Access Key透传配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PassThroughConfig")]
        public AccessKeyPassThroughConfig PassThroughConfig{ get; set; }

        /// <summary>
        /// <p>Access Key 使用模式</p><p>枚举值：</p><ul><li>1： Access Key透传</li></ul>
        /// </summary>
        [JsonProperty("UsageMode")]
        public long? UsageMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamObj(map, prefix + "PassThroughConfig.", this.PassThroughConfig);
            this.SetParamSimple(map, prefix + "UsageMode", this.UsageMode);
        }
    }
}

