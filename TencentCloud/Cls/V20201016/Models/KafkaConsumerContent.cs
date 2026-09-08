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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KafkaConsumerContent : AbstractModel
    {
        
        /// <summary>
        /// <p>消费数据格式。 0：原始内容；1：JSON。</p>
        /// </summary>
        [JsonProperty("Format")]
        public long? Format{ get; set; }

        /// <summary>
        /// <p>是否投递 TAG 信息<br>Format为0时，此字段不需要赋值</p>
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// <p>元数据信息列表, 可选值为：__SOURCE__、__FILENAME__<br>、__TIMESTAMP__、__HOSTNAME__、__PKGID__<br>Format为0时，此字段不需要赋值</p>
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// <p>tag数据处理方式：1:不平铺（默认值）；2:平铺。</p><p>不平铺示例：<br>TAG信息：<code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code><br>不平铺：<code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code></p><p>平铺示例：<br>TAG信息：<code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code><br>平铺：<code>{&quot;__TAG__.fieldA&quot;:200,&quot;__TAG__.fieldB&quot;:&quot;text&quot;}</code></p>
        /// </summary>
        [JsonProperty("TagTransaction")]
        public long? TagTransaction{ get; set; }

        /// <summary>
        /// <p>消费数据Json格式：<br>1：不转义（默认格式）<br>2：转义</p><p>投递Json格式。<br>JsonType为1：和原始日志一致，不转义。示例：<br>日志原文：<code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code><br>投递到Ckafka：<code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code></p><p>JsonType为2：转义。示例：<br>日志原文：<code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code><br>投递到Ckafka：<code>{&quot;a&quot;:&quot;aa&quot;,&quot;b&quot;:&quot;{\&quot;b1\&quot;:\&quot;b1b1\&quot;, \&quot;c1\&quot;:\&quot;c1c1\&quot;}&quot;}</code></p>
        /// </summary>
        [JsonProperty("JsonType")]
        public long? JsonType{ get; set; }

        /// <summary>
        /// <p>数值类型自动转换开关</p><p>枚举值：</p><ul><li>true： JSON 结构中第一层级的 value 中的数字字符串（如 &quot;123&quot; ）会被自动转换为数值类型（int / float）。</li><li>false： JSON 结构中第一层级的 value 中的数字字符串（如 &quot;123&quot; ）为字符串。</li></ul><p>默认值：false</p>
        /// </summary>
        [JsonProperty("AutoConvertNumber")]
        public bool? AutoConvertNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "EnableTag", this.EnableTag);
            this.SetParamArraySimple(map, prefix + "MetaFields.", this.MetaFields);
            this.SetParamSimple(map, prefix + "TagTransaction", this.TagTransaction);
            this.SetParamSimple(map, prefix + "JsonType", this.JsonType);
            this.SetParamSimple(map, prefix + "AutoConvertNumber", this.AutoConvertNumber);
        }
    }
}

