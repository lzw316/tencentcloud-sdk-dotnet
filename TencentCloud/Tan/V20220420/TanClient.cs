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

namespace TencentCloud.Tan.V20220420
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tan.V20220420.Models;

   public class TanClient : AbstractClient{

       private const string endpoint = "tan.tencentcloudapi.com";
       private const string version = "2022-04-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TanClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TanClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建节点记录
        /// </summary>
        /// <param name="req"><see cref="CreateBlockNodeRecordsRequest"/></param>
        /// <returns><see cref="CreateBlockNodeRecordsResponse"/></returns>
        public async Task<CreateBlockNodeRecordsResponse> CreateBlockNodeRecords(CreateBlockNodeRecordsRequest req)
        {
             JsonResponseModel<CreateBlockNodeRecordsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBlockNodeRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlockNodeRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建节点记录
        /// </summary>
        /// <param name="req"><see cref="CreateBlockNodeRecordsRequest"/></param>
        /// <returns><see cref="CreateBlockNodeRecordsResponse"/></returns>
        public CreateBlockNodeRecordsResponse CreateBlockNodeRecordsSync(CreateBlockNodeRecordsRequest req)
        {
             JsonResponseModel<CreateBlockNodeRecordsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBlockNodeRecords");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBlockNodeRecordsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}