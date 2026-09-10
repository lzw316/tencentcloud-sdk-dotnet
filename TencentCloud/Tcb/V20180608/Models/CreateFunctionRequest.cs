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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>创建的函数名称</p>
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// <p>环境ID</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>函数处理方法名称</p>
        /// </summary>
        [JsonProperty("Handler")]
        public string Handler{ get; set; }

        /// <summary>
        /// <p>函数运行时内存大小</p>
        /// </summary>
        [JsonProperty("MemorySize")]
        public long? MemorySize{ get; set; }

        /// <summary>
        /// <p>函数最长执行时间</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>此参数公司内部展示。是否使用GPU进行计算</p>
        /// </summary>
        [JsonProperty("UseGpu")]
        public string UseGpu{ get; set; }

        /// <summary>
        /// <p>在线依赖安装</p>
        /// </summary>
        [JsonProperty("InstallDependency")]
        public string InstallDependency{ get; set; }

        /// <summary>
        /// <p>此参数公司内部展示。用于小程序，GPU集群，不对外</p>
        /// </summary>
        [JsonProperty("Stamp")]
        public string Stamp{ get; set; }

        /// <summary>
        /// <p>函数绑定的角色</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>函数描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>函数运行环境</p>
        /// </summary>
        [JsonProperty("Runtime")]
        public string Runtime{ get; set; }

        /// <summary>
        /// <p>函数日志投递到的CLS TopicID</p>
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// <p>函数日志投递到的CLS LogsetID</p>
        /// </summary>
        [JsonProperty("ClsLogsetId")]
        public string ClsLogsetId{ get; set; }

        /// <summary>
        /// <p>包含函数代码文件的zip格式文件</p>
        /// </summary>
        [JsonProperty("Code")]
        public CodeReq Code{ get; set; }

        /// <summary>
        /// <p>云函数配置项</p>
        /// </summary>
        [JsonProperty("PrivateConfig")]
        public PrivateConfig PrivateConfig{ get; set; }

        /// <summary>
        /// <p>函数类型，默认值为Event，创建触发器函数请填写Event，创建HTTP函数级服务请填写HTTP</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>HTTP函数支持的访问协议。当前支持WebSockets协议，值为WS</p>
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }

        /// <summary>
        /// <p>环境变量</p>
        /// </summary>
        [JsonProperty("Environment")]
        public FunctionEnvironment Environment{ get; set; }

        /// <summary>
        /// <p>函数初始化超时时间，默认 65s，镜像部署函数默认 90s。</p>
        /// </summary>
        [JsonProperty("InitTimeout")]
        public long? InitTimeout{ get; set; }

        /// <summary>
        /// <p>代码来源，支持ZipFile, Cos, Demo 其中之一</p>
        /// </summary>
        [JsonProperty("CodeSource")]
        public string CodeSource{ get; set; }

        /// <summary>
        /// <p>函数的私有网络配置</p>
        /// </summary>
        [JsonProperty("VpcConfig")]
        public FunctionVpcConfig VpcConfig{ get; set; }

        /// <summary>
        /// <p>函数要关联的Layer版本列表，Layer会按照在列表中顺序依次覆盖。</p>
        /// </summary>
        [JsonProperty("Layers")]
        public FunctionLayer[] Layers{ get; set; }

        /// <summary>
        /// <p>公网访问配置</p>
        /// </summary>
        [JsonProperty("PublicNetConfig")]
        public FunctionPublicNetConfig PublicNetConfig{ get; set; }

        /// <summary>
        /// <p>是否开启异步属性，TRUE 为开启，FALSE为关闭</p>
        /// </summary>
        [JsonProperty("AsyncRunEnable")]
        public string AsyncRunEnable{ get; set; }

        /// <summary>
        /// <p>是否开启事件追踪，TRUE 为开启，FALSE为关闭</p>
        /// </summary>
        [JsonProperty("TraceEnable")]
        public string TraceEnable{ get; set; }

        /// <summary>
        /// <p>是否自动创建cls主题，TRUE 为开启，FALSE为关闭</p>
        /// </summary>
        [JsonProperty("AutoCreateClsTopic")]
        public string AutoCreateClsTopic{ get; set; }

        /// <summary>
        /// <p>是否自动创建cls索引，TRUE 为开启，FALSE为关闭</p>
        /// </summary>
        [JsonProperty("AutoDeployClsTopicIndex")]
        public string AutoDeployClsTopicIndex{ get; set; }

        /// <summary>
        /// <p>是否开启Dns缓存能力。只支持EVENT函数。默认为FALSE，TRUE 为开启，FALSE为关闭</p>
        /// </summary>
        [JsonProperty("DnsCache")]
        public string DnsCache{ get; set; }

        /// <summary>
        /// <p>EipConfig固定ip配置</p>
        /// </summary>
        [JsonProperty("EipConfig")]
        public FunctionEipConfigFixed EipConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Handler", this.Handler);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "UseGpu", this.UseGpu);
            this.SetParamSimple(map, prefix + "InstallDependency", this.InstallDependency);
            this.SetParamSimple(map, prefix + "Stamp", this.Stamp);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Runtime", this.Runtime);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "ClsLogsetId", this.ClsLogsetId);
            this.SetParamObj(map, prefix + "Code.", this.Code);
            this.SetParamObj(map, prefix + "PrivateConfig.", this.PrivateConfig);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
            this.SetParamSimple(map, prefix + "InitTimeout", this.InitTimeout);
            this.SetParamSimple(map, prefix + "CodeSource", this.CodeSource);
            this.SetParamObj(map, prefix + "VpcConfig.", this.VpcConfig);
            this.SetParamArrayObj(map, prefix + "Layers.", this.Layers);
            this.SetParamObj(map, prefix + "PublicNetConfig.", this.PublicNetConfig);
            this.SetParamSimple(map, prefix + "AsyncRunEnable", this.AsyncRunEnable);
            this.SetParamSimple(map, prefix + "TraceEnable", this.TraceEnable);
            this.SetParamSimple(map, prefix + "AutoCreateClsTopic", this.AutoCreateClsTopic);
            this.SetParamSimple(map, prefix + "AutoDeployClsTopicIndex", this.AutoDeployClsTopicIndex);
            this.SetParamSimple(map, prefix + "DnsCache", this.DnsCache);
            this.SetParamObj(map, prefix + "EipConfig.", this.EipConfig);
        }
    }
}

