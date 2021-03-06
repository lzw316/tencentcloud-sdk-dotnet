/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Zj.V20190121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddCrowdPackInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户证书
        /// </summary>
        [JsonProperty("License")]
        public string License{ get; set; }

        /// <summary>
        /// 人群包名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 人群包文件名称,人群包文件必须为utf8编码，动态参数只能是汉字、数字、英文字母的组合，不能包含其他字符
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 人群包描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 已经上传好的人群包cos地址
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// 人群包手机号数量
        /// </summary>
        [JsonProperty("PhoneNum")]
        public long? PhoneNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "License", this.License);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
        }
    }
}

