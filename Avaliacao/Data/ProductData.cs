﻿using System;
using System.IO;

namespace Data
{
    public class ProductData
    {
        #region Json
        private const string json = @"[
                  {
                                    'Id': '6fe47896-a88f-4e7f-adde-900cdeb0a297',
                    'Description': 'Cimento',
                    'Value': '495.75',
                    'Company': 'CONCILITY',
                    'CompanyCode': 217
                  },
                  {
                                    'Id': '102cbe29-bc2d-4896-99e0-aa88e64d528d',
                    'Description': 'Areia',
                    'Value': '458.00',
                    'Company': 'BRAINQUIL',
                    'CompanyCode': 514
                  },
                  {
                                    'Id': '4932e9ab-9426-420b-9ea8-1a63be5f24fd',
                    'Description': 'Cimento',
                    'Value': '360.70',
                    'Company': 'SIGNITY',
                    'CompanyCode': 9
                  },
                  {
                                    'Id': '2035d569-ed49-4da1-8353-87ad901d9753',
                    'Description': 'Cimento',
                    'Value': '143.70',
                    'Company': 'NETPLAX',
                    'CompanyCode': 210
                  },
                  {
                                    'Id': '0199421a-0a91-4e42-afc2-80b608572738',
                    'Description': 'Areia',
                    'Value': '151.21',
                    'Company': 'MANGLO',
                    'CompanyCode': 383
                  },
                  {
                                    'Id': 'ba8d71a9-377e-4b8c-ab0b-2aa3318ffd04',
                    'Description': 'Cimento',
                    'Value': '190.34',
                    'Company': 'EXOVENT',
                    'CompanyCode': 253
                  },
                  {
                                    'Id': '72273a0d-ebbc-464e-8fb8-07d3c1ee2200',
                    'Description': 'Areia',
                    'Value': '387.68',
                    'Company': 'ATOMICA',
                    'CompanyCode': 227
                  },
                  {
                                    'Id': 'c8f7eca6-a001-4baf-91ad-760e8050bfe1',
                    'Description': 'Madeira',
                    'Value': '164.51',
                    'Company': 'MAROPTIC',
                    'CompanyCode': 376
                  },
                  {
                                    'Id': 'bc785ccb-c45c-433e-bffd-a501b24bcde5',
                    'Description': 'Areia',
                    'Value': '213.46',
                    'Company': 'ZOUNDS',
                    'CompanyCode': 433
                  },
                  {
                                    'Id': '23ea933f-d781-4547-961b-2035aa97d90e',
                    'Description': 'Madeira',
                    'Value': '103.97',
                    'Company': 'EYEWAX',
                    'CompanyCode': 851
                  },
                  {
                                    'Id': '52d6512a-c83e-4fff-a3b0-3ba2568505ef',
                    'Description': 'Madeira',
                    'Value': '144.06',
                    'Company': 'XPLOR',
                    'CompanyCode': 708
                  },
                  {
                                    'Id': '819c49d8-f46b-48c5-bfcd-0dafdb147550',
                    'Description': 'Areia',
                    'Value': '335.59',
                    'Company': 'INFOTRIPS',
                    'CompanyCode': 651
                  },
                  {
                                    'Id': '12edfa86-5988-473c-9556-e85161e16603',
                    'Description': 'Madeira',
                    'Value': '402.88',
                    'Company': 'PAPRICUT',
                    'CompanyCode': 366
                  },
                  {
                                    'Id': '7f0573e7-3bb6-47f3-a415-5c1ace4ac3c0',
                    'Description': 'Cimento',
                    'Value': '378.29',
                    'Company': 'VIOCULAR',
                    'CompanyCode': 384
                  },
                  {
                                    'Id': '34f060dd-174e-4950-b614-05c9c35f383f',
                    'Description': 'Cimento',
                    'Value': '419.57',
                    'Company': 'DELPHIDE',
                    'CompanyCode': 506
                  },
                  {
                                    'Id': 'ec1ae3f5-1469-4b8c-bab3-d4fcd8b5d47d',
                    'Description': 'Cimento',
                    'Value': '447.40',
                    'Company': 'HIVEDOM',
                    'CompanyCode': 237
                  },
                  {
                                    'Id': '05e2c928-9af0-4ae8-90ec-5e6d648a2334',
                    'Description': 'Cimento',
                    'Value': '316.38',
                    'Company': 'DIGIRANG',
                    'CompanyCode': 438
                  },
                  {
                                    'Id': '9db04469-1a97-4f1b-892c-dd9ad0e77438',
                    'Description': 'Cimento',
                    'Value': '189.56',
                    'Company': 'DENTREX',
                    'CompanyCode': 164
                  },
                  {
                                    'Id': '31675aad-1134-42c9-acaf-b52ea0fab63b',
                    'Description': 'Areia',
                    'Value': '298.72',
                    'Company': 'MOBILDATA',
                    'CompanyCode': 874
                  },
                  {
                                    'Id': '2c800b6d-be2d-49f2-ab59-8baa0650275a',
                    'Description': 'Areia',
                    'Value': '240.17',
                    'Company': 'COMBOT',
                    'CompanyCode': 256
                  },
                  {
                                    'Id': '6127b296-3175-4add-a434-dd8671be508e',
                    'Description': 'Areia',
                    'Value': '288.06',
                    'Company': 'SLAX',
                    'CompanyCode': 712
                  },
                  {
                                    'Id': '20dec6a2-17a8-4e63-8f83-34a5142c5d44',
                    'Description': 'Cimento',
                    'Value': '244.38',
                    'Company': 'KLUGGER',
                    'CompanyCode': 592
                  },
                  {
                                    'Id': '7bc07887-5435-45c1-b4cc-c4a43ae2c869',
                    'Description': 'Areia',
                    'Value': '122.12',
                    'Company': 'STOCKPOST',
                    'CompanyCode': 109
                  },
                  {
                                    'Id': '0ad27a24-5de5-4c2e-84f7-8f69a67edbfa',
                    'Description': 'Cimento',
                    'Value': '274.85',
                    'Company': 'QUIZKA',
                    'CompanyCode': 368
                  },
                  {
                                    'Id': '00f883b5-caa6-4108-8090-db96cf90ba77',
                    'Description': 'Cimento',
                    'Value': '169.45',
                    'Company': 'INSURESYS',
                    'CompanyCode': 46
                  },
                  {
                                    'Id': 'e7a03058-2ab5-410f-b61e-7521de2110f7',
                    'Description': 'Cimento',
                    'Value': '141.96',
                    'Company': 'GOGOL',
                    'CompanyCode': 941
                  },
                  {
                                    'Id': 'a002c091-1674-4c23-b99b-6a00782f4f79',
                    'Description': 'Madeira',
                    'Value': '379.26',
                    'Company': 'EARWAX',
                    'CompanyCode': 141
                  },
                  {
                                    'Id': 'ddb3f169-dbda-4a41-a544-7e0916d5fb5f',
                    'Description': 'Areia',
                    'Value': '226.29',
                    'Company': 'EDECINE',
                    'CompanyCode': 953
                  },
                  {
                                    'Id': '866f4464-474a-452f-b23b-7dabd56dff79',
                    'Description': 'Madeira',
                    'Value': '240.62',
                    'Company': 'INSURITY',
                    'CompanyCode': 40
                  },
                  {
                                    'Id': '319d3818-6685-4975-9bba-00b61abe96b4',
                    'Description': 'Areia',
                    'Value': '228.89',
                    'Company': 'VIDTO',
                    'CompanyCode': 350
                  },
                  {
                                    'Id': 'db403703-8cc2-41ba-a16e-7615317765f7',
                    'Description': 'Areia',
                    'Value': '373.91',
                    'Company': 'EVIDENDS',
                    'CompanyCode': 91
                  },
                  {
                                    'Id': '32f334bd-e1bf-445f-b9b8-453e492a5fb8',
                    'Description': 'Cimento',
                    'Value': '334.05',
                    'Company': 'ENERVATE',
                    'CompanyCode': 147
                  },
                  {
                                    'Id': 'ee357b22-c09e-4f74-b574-0b782dd43d74',
                    'Description': 'Cimento',
                    'Value': '303.80',
                    'Company': 'MEDCOM',
                    'CompanyCode': 941
                  },
                  {
                                    'Id': '49aa83f2-4ca9-4db0-ae93-d2c57fef71c4',
                    'Description': 'Areia',
                    'Value': '466.57',
                    'Company': 'XEREX',
                    'CompanyCode': 300
                  },
                  {
                                    'Id': '1f7c5683-42c5-4f17-82dd-363bae27542d',
                    'Description': 'Madeira',
                    'Value': '394.30',
                    'Company': 'ENDIPIN',
                    'CompanyCode': 471
                  },
                  {
                                    'Id': 'fad4dfe2-9f68-4811-aaa3-b2906ba53ce1',
                    'Description': 'Cimento',
                    'Value': '186.92',
                    'Company': 'LIMOZEN',
                    'CompanyCode': 934
                  },
                  {
                                    'Id': '59fcd0a8-dd36-4580-b338-1cb1c5948508',
                    'Description': 'Areia',
                    'Value': '456.77',
                    'Company': 'CALCULA',
                    'CompanyCode': 822
                  },
                  {
                                    'Id': '09d189c9-e545-4010-927f-762fdf2ecb77',
                    'Description': 'Areia',
                    'Value': '150.77',
                    'Company': 'ECRATIC',
                    'CompanyCode': 362
                  },
                  {
                                    'Id': 'f9154d06-686b-4713-8fde-26b8faa8a7a4',
                    'Description': 'Areia',
                    'Value': '322.08',
                    'Company': 'GEEKY',
                    'CompanyCode': 372
                  },
                  {
                                    'Id': 'f17161a4-b109-44f5-8a26-3fe1356a5c45',
                    'Description': 'Madeira',
                    'Value': '422.26',
                    'Company': 'KIGGLE',
                    'CompanyCode': 991
                  },
                  {
                                    'Id': 'bd902227-14c4-4c38-a09c-24ff3a702cd3',
                    'Description': 'Areia',
                    'Value': '260.70',
                    'Company': 'MAGNAFONE',
                    'CompanyCode': 373
                  },
                  {
                                    'Id': 'a6d9ef4f-c376-4290-9799-5cf255a3785e',
                    'Description': 'Areia',
                    'Value': '279.12',
                    'Company': 'DECRATEX',
                    'CompanyCode': 149
                  },
                  {
                                    'Id': 'c95e85a0-e076-416a-ba73-75ef7e4cebe8',
                    'Description': 'Madeira',
                    'Value': '264.18',
                    'Company': 'BEADZZA',
                    'CompanyCode': 6
                  },
                  {
                                    'Id': 'a2333917-1f6d-4016-b979-0df1ec304138',
                    'Description': 'Cimento',
                    'Value': '152.16',
                    'Company': 'BOILCAT',
                    'CompanyCode': 290
                  },
                  {
                                    'Id': 'beb6f5d3-cdf3-45bc-bfa8-f7a07ce29f2e',
                    'Description': 'Areia',
                    'Value': '499.91',
                    'Company': 'OPTICOM',
                    'CompanyCode': 294
                  },
                  {
                                    'Id': 'f965e3de-6701-4366-a5f6-95180a633b2d',
                    'Description': 'Madeira',
                    'Value': '204.10',
                    'Company': 'POWERNET',
                    'CompanyCode': 546
                  },
                  {
                                    'Id': '33e06d7d-2340-4aec-afe5-47e79071d059',
                    'Description': 'Madeira',
                    'Value': '317.03',
                    'Company': 'ZANITY',
                    'CompanyCode': 428
                  },
                  {
                                    'Id': '5a0f7ba9-573a-4d6c-b34c-40b71deb3fa4',
                    'Description': 'Areia',
                    'Value': '390.57',
                    'Company': 'ISOLOGIX',
                    'CompanyCode': 824
                  },
                  {
                                    'Id': '97834e6e-f073-453b-8db0-b8649b4bd510',
                    'Description': 'Madeira',
                    'Value': '134.66',
                    'Company': 'AQUAZURE',
                    'CompanyCode': 170
                  },
                  {
                                    'Id': '5032d675-d091-47bc-a9cd-9295df90f443',
                    'Description': 'Madeira',
                    'Value': '201.79',
                    'Company': 'INTRADISK',
                    'CompanyCode': 612
                  },
                  {
                                    'Id': '9d1d400d-4bf6-4958-897a-4a90bdf00a92',
                    'Description': 'Cimento',
                    'Value': '184.76',
                    'Company': 'WRAPTURE',
                    'CompanyCode': 394
                  },
                  {
                                    'Id': 'e9ac4c5a-7138-48f8-b4e9-58cc9cbebb58',
                    'Description': 'Cimento',
                    'Value': '381.65',
                    'Company': 'EVEREST',
                    'CompanyCode': 537
                  },
                  {
                                    'Id': 'b1ed6e6e-bb6b-43e9-a12d-1aa6adf5e36b',
                    'Description': 'Areia',
                    'Value': '334.19',
                    'Company': 'EXTRAWEAR',
                    'CompanyCode': 286
                  },
                  {
                                    'Id': 'fde1a65f-da3e-47b0-87d3-e00810066e55',
                    'Description': 'Madeira',
                    'Value': '437.50',
                    'Company': 'ASSITIA',
                    'CompanyCode': 651
                  },
                  {
                                    'Id': 'e090c049-3b80-44fa-88f9-f0df616170f3',
                    'Description': 'Cimento',
                    'Value': '239.89',
                    'Company': 'PROGENEX',
                    'CompanyCode': 793
                  },
                  {
                                    'Id': '79a17764-7861-4c82-a23b-1fbb80a295c3',
                    'Description': 'Madeira',
                    'Value': '376.54',
                    'Company': 'PATHWAYS',
                    'CompanyCode': 480
                  },
                  {
                                    'Id': 'edf6d8da-648b-4db5-ba60-2b7c15893332',
                    'Description': 'Madeira',
                    'Value': '205.62',
                    'Company': 'PASTURIA',
                    'CompanyCode': 408
                  },
                  {
                                    'Id': '71a724f1-f496-4e6f-bb4d-2fbf5823b3ea',
                    'Description': 'Cimento',
                    'Value': '281.87',
                    'Company': 'STROZEN',
                    'CompanyCode': 318
                  },
                  {
                                    'Id': 'ae949b86-c4cd-4453-939b-480693434297',
                    'Description': 'Cimento',
                    'Value': '107.48',
                    'Company': 'ZIPAK',
                    'CompanyCode': 325
                  },
                  {
                                    'Id': '1101298e-e9c5-45b5-a506-2b4290451b5f',
                    'Description': 'Madeira',
                    'Value': '186.65',
                    'Company': 'KONNECT',
                    'CompanyCode': 11
                  },
                  {
                                    'Id': 'e41d4b29-8607-4da7-ace8-af8787118a19',
                    'Description': 'Areia',
                    'Value': '175.06',
                    'Company': 'PORTALIS',
                    'CompanyCode': 318
                  },
                  {
                                    'Id': '97466703-3284-448e-86c6-26e8f82448bc',
                    'Description': 'Areia',
                    'Value': '238.17',
                    'Company': 'EWAVES',
                    'CompanyCode': 286
                  },
                  {
                                    'Id': '847d8c74-1dcd-474e-bc83-a891fbd318a7',
                    'Description': 'Cimento',
                    'Value': '145.22',
                    'Company': 'FORTEAN',
                    'CompanyCode': 843
                  },
                  {
                                    'Id': '76bc4180-9505-4f5f-bcf0-8cfe591b1802',
                    'Description': 'Areia',
                    'Value': '160.31',
                    'Company': 'MAGNEMO',
                    'CompanyCode': 700
                  },
                  {
                                    'Id': 'ebe30436-6c79-4199-b3ab-c56f7147bc5c',
                    'Description': 'Madeira',
                    'Value': '224.42',
                    'Company': 'AUSTEX',
                    'CompanyCode': 923
                  },
                  {
                                    'Id': '857c936b-04f0-4454-a0ba-caaf8043c959',
                    'Description': 'Madeira',
                    'Value': '151.93',
                    'Company': 'OVERFORK',
                    'CompanyCode': 840
                  },
                  {
                                    'Id': 'd2f6838d-9dbd-4e5a-be54-81768cf27f41',
                    'Description': 'Cimento',
                    'Value': '312.33',
                    'Company': 'APEX',
                    'CompanyCode': 687
                  },
                  {
                                    'Id': 'dbd70511-d7c7-4078-90c5-dc5bc41a7596',
                    'Description': 'Cimento',
                    'Value': '299.62',
                    'Company': 'COMTOURS',
                    'CompanyCode': 539
                  },
                  {
                                    'Id': 'a8947a90-e445-44d5-a06c-e6598b380308',
                    'Description': 'Cimento',
                    'Value': '272.35',
                    'Company': 'OPTICON',
                    'CompanyCode': 623
                  },
                  {
                                    'Id': '65155056-a21b-41a1-8203-dde14dc723a4',
                    'Description': 'Cimento',
                    'Value': '439.51',
                    'Company': 'COMTRACT',
                    'CompanyCode': 649
                  },
                  {
                                    'Id': 'def34b82-1584-40f4-af5f-24f613954ed4',
                    'Description': 'Madeira',
                    'Value': '417.68',
                    'Company': 'JASPER',
                    'CompanyCode': 394
                  },
                  {
                                    'Id': 'abfd51d4-3baf-4a88-b852-d65a59d218bc',
                    'Description': 'Cimento',
                    'Value': '235.85',
                    'Company': 'BIOLIVE',
                    'CompanyCode': 525
                  },
                  {
                                    'Id': '9f05eefb-a0ca-4d51-91db-6d364cae94b3',
                    'Description': 'Cimento',
                    'Value': '176.27',
                    'Company': 'CALCU',
                    'CompanyCode': 373
                  },
                  {
                                    'Id': '0b046bcb-d387-4538-ad5e-8ba54a642f81',
                    'Description': 'Areia',
                    'Value': '235.94',
                    'Company': 'MOLTONIC',
                    'CompanyCode': 622
                  },
                  {
                                    'Id': 'f2e73cee-6358-4efe-80be-70bcfb175a43',
                    'Description': 'Madeira',
                    'Value': '255.29',
                    'Company': 'ZEPITOPE',
                    'CompanyCode': 885
                  },
                  {
                                    'Id': 'b38c1300-7be3-440f-9e72-ebbb1ecd0486',
                    'Description': 'Madeira',
                    'Value': '274.16',
                    'Company': 'VOLAX',
                    'CompanyCode': 371
                  },
                  {
                                    'Id': '162c6dd2-b8be-44b3-a841-112f45f4f0ad',
                    'Description': 'Areia',
                    'Value': '136.99',
                    'Company': 'ACLIMA',
                    'CompanyCode': 50
                  },
                  {
                                    'Id': 'c653dd8f-9fb5-44f3-9009-47be651cd4d5',
                    'Description': 'Areia',
                    'Value': '451.85',
                    'Company': 'DEVILTOE',
                    'CompanyCode': 248
                  },
                  {
                                    'Id': '4a3b05db-d14f-4f18-947f-98f17804438a',
                    'Description': 'Madeira',
                    'Value': '428.30',
                    'Company': 'ISOLOGICA',
                    'CompanyCode': 263
                  },
                  {
                                    'Id': '4684ed91-9520-46ba-8662-8e8a720bcec2',
                    'Description': 'Madeira',
                    'Value': '368.10',
                    'Company': 'POLARIUM',
                    'CompanyCode': 846
                  },
                  {
                                    'Id': '4976c069-4d73-4f86-9563-8de9dd9fbe07',
                    'Description': 'Areia',
                    'Value': '385.99',
                    'Company': 'DYMI',
                    'CompanyCode': 886
                  },
                  {
                                    'Id': 'ac88dd43-17b9-453b-8dd3-183dc44f2702',
                    'Description': 'Cimento',
                    'Value': '303.53',
                    'Company': 'AFFLUEX',
                    'CompanyCode': 846
                  },
                  {
                                    'Id': '436b077d-fccb-4be0-a771-d045b3293f39',
                    'Description': 'Madeira',
                    'Value': '470.37',
                    'Company': 'SLOFAST',
                    'CompanyCode': 629
                  },
                  {
                                    'Id': 'de7ba5fc-d485-456b-ab6a-2f9bdfd04a62',
                    'Description': 'Areia',
                    'Value': '342.46',
                    'Company': 'SHOPABOUT',
                    'CompanyCode': 727
                  },
                  {
                                    'Id': '0b8e8243-7c40-4328-a71a-11cc01c18be3',
                    'Description': 'Cimento',
                    'Value': '332.64',
                    'Company': 'SHEPARD',
                    'CompanyCode': 463
                  },
                  {
                                    'Id': '8a7c8c77-adb9-42bc-9b9f-ff640620cac9',
                    'Description': 'Areia',
                    'Value': '419.05',
                    'Company': 'ZENTILITY',
                    'CompanyCode': 968
                  },
                  {
                                    'Id': 'd0debdc4-c61d-4753-b2a0-2028362e798f',
                    'Description': 'Madeira',
                    'Value': '358.43',
                    'Company': 'QUONATA',
                    'CompanyCode': 498
                  },
                  {
                                    'Id': 'c0c256f2-188c-438a-a41e-1ba0c37a3388',
                    'Description': 'Cimento',
                    'Value': '155.04',
                    'Company': 'GRAINSPOT',
                    'CompanyCode': 923
                  },
                  {
                                    'Id': '2eeac7e4-4059-4b5c-952d-e87c8d5a4082',
                    'Description': 'Madeira',
                    'Value': '335.13',
                    'Company': 'YURTURE',
                    'CompanyCode': 560
                  },
                  {
                                    'Id': 'f90391b1-7bdb-43f1-be23-9e06101ca12f',
                    'Description': 'Cimento',
                    'Value': '197.43',
                    'Company': 'NURPLEX',
                    'CompanyCode': 685
                  },
                  {
                                    'Id': 'c6cf3014-ac66-4619-a9b2-2a19c75d1b0f',
                    'Description': 'Madeira',
                    'Value': '129.09',
                    'Company': 'BOINK',
                    'CompanyCode': 129
                  }
                ]";

        #endregion

        public string GetAll()
        {
            return json;
        }
    }
}