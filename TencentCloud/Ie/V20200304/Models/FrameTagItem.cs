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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FrameTagItem : AbstractModel
    {
        
        /// <summary>
        /// 标签起始时间戳PTS(ms)
        /// </summary>
        [JsonProperty("StartPts")]
        public ulong? StartPts{ get; set; }

        /// <summary>
        /// 语句结束时间戳PTS(ms)
        /// </summary>
        [JsonProperty("EndPts")]
        public ulong? EndPts{ get; set; }

        /// <summary>
        /// 字符串形式的起始结束时间
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// 标签数组
        /// </summary>
        [JsonProperty("TagItems")]
        public TagItem[] TagItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartPts", this.StartPts);
            this.SetParamSimple(map, prefix + "EndPts", this.EndPts);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
        }
    }
}

