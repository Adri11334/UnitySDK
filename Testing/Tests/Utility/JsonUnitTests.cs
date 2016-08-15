using System;
using System.Collections.Generic;
using PlayFab.Internal;
using PlayFab.Json;

namespace PlayFab.UUnit
{
    public enum Region
    {
        USCentral,
        USEast,
        EUWest,
        Singapore,
        Japan,
        Brazil,
        Australia
    }

    internal class JsonPropertyAttrTestClass
    {
        [JsonProperty(PropertyName = "GoodField")]
        public string InvalidField;
        [JsonProperty(PropertyName = "GoodProperty")]
        public string InvalidProperty { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object HideNull = null;
        public object ShowNull = null;
    }

    internal class NullableTestClass
    {
        public int? IntField = null;
        public int? IntProperty { get; set; }
        public DateTime? TimeField = null;
        public DateTime? TimeProperty { get; set; }
        public Region? EnumField = null;
        public Region? EnumProperty { get; set; }
    }

    internal class ObjNumFieldTest
    {
        public sbyte SbyteValue; public byte ByteValue;
        public short ShortValue; public ushort UshortValue;
        public int IntValue; public uint UintValue;
        public long LongValue; public ulong UlongValue;
        public float FloatValue; public double DoubleValue;

        public static ObjNumFieldTest Max = new ObjNumFieldTest { SbyteValue = sbyte.MaxValue, ByteValue = byte.MaxValue, ShortValue = short.MaxValue, UshortValue = ushort.MaxValue, IntValue = int.MaxValue, UintValue = uint.MaxValue, LongValue = long.MaxValue, UlongValue = ulong.MaxValue, FloatValue = float.MaxValue, DoubleValue = double.MaxValue };
        public static ObjNumFieldTest Min = new ObjNumFieldTest { SbyteValue = sbyte.MinValue, ByteValue = byte.MinValue, ShortValue = short.MinValue, UshortValue = ushort.MinValue, IntValue = int.MinValue, UintValue = uint.MinValue, LongValue = long.MinValue, UlongValue = ulong.MinValue, FloatValue = float.MinValue, DoubleValue = double.MinValue };
        public static ObjNumFieldTest Zero = new ObjNumFieldTest();
    }
    internal class ObjNumPropTest
    {
        public sbyte SbyteValue { get; set; }
        public byte ByteValue { get; set; }
        public short ShortValue { get; set; }
        public ushort UshortValue { get; set; }
        public int IntValue { get; set; }
        public uint UintValue { get; set; }
        public long LongValue { get; set; }
        public ulong UlongValue { get; set; }
        public float FloatValue { get; set; }
        public double DoubleValue { get; set; }

        public static ObjNumPropTest Max = new ObjNumPropTest { SbyteValue = sbyte.MaxValue, ByteValue = byte.MaxValue, ShortValue = short.MaxValue, UshortValue = ushort.MaxValue, IntValue = int.MaxValue, UintValue = uint.MaxValue, LongValue = long.MaxValue, UlongValue = ulong.MaxValue, FloatValue = float.MaxValue, DoubleValue = double.MaxValue };
        public static ObjNumPropTest Min = new ObjNumPropTest { SbyteValue = sbyte.MinValue, ByteValue = byte.MinValue, ShortValue = short.MinValue, UshortValue = ushort.MinValue, IntValue = int.MinValue, UintValue = uint.MinValue, LongValue = long.MinValue, UlongValue = ulong.MinValue, FloatValue = float.MinValue, DoubleValue = double.MinValue };
        public static ObjNumPropTest Zero = new ObjNumPropTest();
    }
    internal struct StructNumFieldTest
    {
        public sbyte SbyteValue; public byte ByteValue;
        public short ShortValue; public ushort UshortValue;
        public int IntValue; public uint UintValue;
        public long LongValue; public ulong UlongValue;
        public float FloatValue; public double DoubleValue;

        public static StructNumFieldTest Max = new StructNumFieldTest { SbyteValue = sbyte.MaxValue, ByteValue = byte.MaxValue, ShortValue = short.MaxValue, UshortValue = ushort.MaxValue, IntValue = int.MaxValue, UintValue = uint.MaxValue, LongValue = long.MaxValue, UlongValue = ulong.MaxValue, FloatValue = float.MaxValue, DoubleValue = double.MaxValue };
        public static StructNumFieldTest Min = new StructNumFieldTest { SbyteValue = sbyte.MinValue, ByteValue = byte.MinValue, ShortValue = short.MinValue, UshortValue = ushort.MinValue, IntValue = int.MinValue, UintValue = uint.MinValue, LongValue = long.MinValue, UlongValue = ulong.MinValue, FloatValue = float.MinValue, DoubleValue = double.MinValue };
        public static StructNumFieldTest Zero = new StructNumFieldTest();
    }
    internal class ObjOptNumFieldTest
    {
        public sbyte? SbyteValue { get; set; }
        public byte? ByteValue { get; set; }
        public short? ShortValue { get; set; }
        public ushort? UshortValue { get; set; }
        public int? IntValue { get; set; }
        public uint? UintValue { get; set; }
        public long? LongValue { get; set; }
        public ulong? UlongValue { get; set; }
        public float? FloatValue { get; set; }
        public double? DoubleValue { get; set; }

        public static ObjOptNumFieldTest Max = new ObjOptNumFieldTest { SbyteValue = sbyte.MaxValue, ByteValue = byte.MaxValue, ShortValue = short.MaxValue, UshortValue = ushort.MaxValue, IntValue = int.MaxValue, UintValue = uint.MaxValue, LongValue = long.MaxValue, UlongValue = ulong.MaxValue, FloatValue = float.MaxValue, DoubleValue = double.MaxValue };
        public static ObjOptNumFieldTest Min = new ObjOptNumFieldTest { SbyteValue = sbyte.MinValue, ByteValue = byte.MinValue, ShortValue = short.MinValue, UshortValue = ushort.MinValue, IntValue = int.MinValue, UintValue = uint.MinValue, LongValue = long.MinValue, UlongValue = ulong.MinValue, FloatValue = float.MinValue, DoubleValue = double.MinValue };
        public static ObjOptNumFieldTest Zero = new ObjOptNumFieldTest { SbyteValue = 0, ByteValue = 0, ShortValue = 0, UshortValue = 0, IntValue = 0, UintValue = 0, LongValue = 0, UlongValue = 0, FloatValue = 0, DoubleValue = 0 };
        public static ObjOptNumFieldTest Null = new ObjOptNumFieldTest { SbyteValue = null, ByteValue = null, ShortValue = null, UshortValue = null, IntValue = null, UintValue = null, LongValue = null, UlongValue = null, FloatValue = null, DoubleValue = null };
    }

    internal class OtherSpecificDatatypes
    {
        public Dictionary<string, string> StringDict { get; set; }
        public Dictionary<string, int> IntDict { get; set; }
        public Dictionary<string, uint> UintDict { get; set; }
        public Dictionary<string, Region> EnumDict { get; set; }
        public string TestString { get; set; }
    }

    public class JsonFeatureTests : UUnitTestCase
    {
        [UUnitTest]
        public void JsonPropertyTest(UUnitTestContext testContext)
        {
            var expectedObject = new JsonPropertyAttrTestClass { InvalidField = "asdf", InvalidProperty = "fdsa" };
            string json = JsonWrapper.SerializeObject(expectedObject);
            // Verify that the field names have been transformed by the JsonProperty attribute
            testContext.False(json.ToLower().Contains("invalid"), json);
            testContext.False(json.ToLower().Contains("hidenull"), json);
            testContext.True(json.ToLower().Contains("shownull"), json);

            // Verify that the fields are re-serialized into the proper locations by the JsonProperty attribute
            var actualObject = JsonWrapper.DeserializeObject<JsonPropertyAttrTestClass>(json);
            testContext.StringEquals(expectedObject.InvalidField, actualObject.InvalidField, actualObject.InvalidField);
            testContext.StringEquals(expectedObject.InvalidProperty, actualObject.InvalidProperty, actualObject.InvalidProperty);

            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void TestObjNumField(UUnitTestContext testContext)
        {
            var expectedObjects = new[] { ObjNumFieldTest.Max, ObjNumFieldTest.Min, ObjNumFieldTest.Zero };
            for (int i = 0; i < expectedObjects.Length; i++)
            {
                // Convert the object to json and back, and verify that everything is the same
                var actualJson = JsonWrapper.SerializeObject(expectedObjects[i], PlayFabUtil.ApiSerializerStrategy).Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
                var actualObject = JsonWrapper.DeserializeObject<ObjNumFieldTest>(actualJson, PlayFabUtil.ApiSerializerStrategy);

                testContext.SbyteEquals(expectedObjects[i].SbyteValue, actualObject.SbyteValue);
                testContext.ByteEquals(expectedObjects[i].ByteValue, actualObject.ByteValue);
                testContext.ShortEquals(expectedObjects[i].ShortValue, actualObject.ShortValue);
                testContext.UshortEquals(expectedObjects[i].UshortValue, actualObject.UshortValue);
                testContext.IntEquals(expectedObjects[i].IntValue, actualObject.IntValue);
                testContext.UintEquals(expectedObjects[i].UintValue, actualObject.UintValue);
                testContext.LongEquals(expectedObjects[i].LongValue, actualObject.LongValue);
                testContext.ULongEquals(expectedObjects[i].UlongValue, actualObject.UlongValue);
                testContext.FloatEquals(expectedObjects[i].FloatValue, actualObject.FloatValue, 0.001f);
                testContext.DoubleEquals(expectedObjects[i].DoubleValue, actualObject.DoubleValue, 0.001);
            }
            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void TestObjNumProp(UUnitTestContext testContext)
        {
            var expectedObjects = new[] { ObjNumPropTest.Max, ObjNumPropTest.Min, ObjNumPropTest.Zero };
            for (int i = 0; i < expectedObjects.Length; i++)
            {
                // Convert the object to json and back, and verify that everything is the same
                var actualJson = JsonWrapper.SerializeObject(expectedObjects[i], PlayFabUtil.ApiSerializerStrategy).Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
                var actualObject = JsonWrapper.DeserializeObject<ObjNumPropTest>(actualJson, PlayFabUtil.ApiSerializerStrategy);

                testContext.SbyteEquals(expectedObjects[i].SbyteValue, actualObject.SbyteValue);
                testContext.ByteEquals(expectedObjects[i].ByteValue, actualObject.ByteValue);
                testContext.ShortEquals(expectedObjects[i].ShortValue, actualObject.ShortValue);
                testContext.UshortEquals(expectedObjects[i].UshortValue, actualObject.UshortValue);
                testContext.IntEquals(expectedObjects[i].IntValue, actualObject.IntValue);
                testContext.UintEquals(expectedObjects[i].UintValue, actualObject.UintValue);
                testContext.LongEquals(expectedObjects[i].LongValue, actualObject.LongValue);
                testContext.ULongEquals(expectedObjects[i].UlongValue, actualObject.UlongValue);
                testContext.FloatEquals(expectedObjects[i].FloatValue, actualObject.FloatValue, float.MaxValue * 0.000000001f);
                testContext.DoubleEquals(expectedObjects[i].DoubleValue, actualObject.DoubleValue, double.MaxValue * 0.000000001f);
            }
            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void TestStructNumField(UUnitTestContext testContext)
        {
            var expectedObjects = new[] { StructNumFieldTest.Max, StructNumFieldTest.Min, StructNumFieldTest.Zero };
            for (int i = 0; i < expectedObjects.Length; i++)
            {
                // Convert the object to json and back, and verify that everything is the same
                var actualJson = JsonWrapper.SerializeObject(expectedObjects[i], PlayFabUtil.ApiSerializerStrategy).Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
                var actualObject = JsonWrapper.DeserializeObject<ObjNumPropTest>(actualJson, PlayFabUtil.ApiSerializerStrategy);

                testContext.SbyteEquals(expectedObjects[i].SbyteValue, actualObject.SbyteValue);
                testContext.ByteEquals(expectedObjects[i].ByteValue, actualObject.ByteValue);
                testContext.ShortEquals(expectedObjects[i].ShortValue, actualObject.ShortValue);
                testContext.UshortEquals(expectedObjects[i].UshortValue, actualObject.UshortValue);
                testContext.IntEquals(expectedObjects[i].IntValue, actualObject.IntValue);
                testContext.UintEquals(expectedObjects[i].UintValue, actualObject.UintValue);
                testContext.LongEquals(expectedObjects[i].LongValue, actualObject.LongValue);
                testContext.ULongEquals(expectedObjects[i].UlongValue, actualObject.UlongValue);
                testContext.FloatEquals(expectedObjects[i].FloatValue, actualObject.FloatValue, float.MaxValue * 0.000000001f);
                testContext.DoubleEquals(expectedObjects[i].DoubleValue, actualObject.DoubleValue, double.MaxValue * 0.000000001f);
            }
            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void TestObjOptNumField(UUnitTestContext testContext)
        {
            var expectedObjects = new[] { ObjOptNumFieldTest.Max, ObjOptNumFieldTest.Min, ObjOptNumFieldTest.Zero, ObjOptNumFieldTest.Null };
            for (int i = 0; i < expectedObjects.Length; i++)
            {
                // Convert the object to json and back, and verify that everything is the same
                var actualJson = JsonWrapper.SerializeObject(expectedObjects[i], PlayFabUtil.ApiSerializerStrategy).Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
                var actualObject = JsonWrapper.DeserializeObject<ObjOptNumFieldTest>(actualJson, PlayFabUtil.ApiSerializerStrategy);

                testContext.SbyteEquals(expectedObjects[i].SbyteValue, actualObject.SbyteValue);
                testContext.ByteEquals(expectedObjects[i].ByteValue, actualObject.ByteValue);
                testContext.ShortEquals(expectedObjects[i].ShortValue, actualObject.ShortValue);
                testContext.UshortEquals(expectedObjects[i].UshortValue, actualObject.UshortValue);
                testContext.IntEquals(expectedObjects[i].IntValue, actualObject.IntValue);
                testContext.UintEquals(expectedObjects[i].UintValue, actualObject.UintValue);
                testContext.LongEquals(expectedObjects[i].LongValue, actualObject.LongValue);
                testContext.ULongEquals(expectedObjects[i].UlongValue, actualObject.UlongValue);
                testContext.FloatEquals(expectedObjects[i].FloatValue, actualObject.FloatValue, float.MaxValue * 0.000000001f);
                testContext.DoubleEquals(expectedObjects[i].DoubleValue, actualObject.DoubleValue, double.MaxValue * 0.000000001f);
            }
            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void OtherSpecificDatatypes(UUnitTestContext testContext)
        {
            var expectedObj = new OtherSpecificDatatypes
            {
                StringDict = new Dictionary<string, string> { { "stringKey", "stringValue" } },
                EnumDict = new Dictionary<string, Region> { { "enumKey", Region.Japan } },
                IntDict = new Dictionary<string, int> { { "intKey", int.MinValue } },
                UintDict = new Dictionary<string, uint> { { "uintKey", uint.MaxValue } },
                TestString = "yup",
            };
            // Convert the object to json and back, and verify that everything is the same
            var actualJson = JsonWrapper.SerializeObject(expectedObj, PlayFabUtil.ApiSerializerStrategy).Replace(" ", "").Replace("\n", "").Replace("\r", "").Replace("\t", "");
            var actualObject = JsonWrapper.DeserializeObject<OtherSpecificDatatypes>(actualJson, PlayFabUtil.ApiSerializerStrategy);

            testContext.ObjEquals(expectedObj.TestString, actualObject.TestString);
            testContext.SequenceEquals(expectedObj.IntDict, actualObject.IntDict);
            testContext.SequenceEquals(expectedObj.UintDict, actualObject.UintDict);
            testContext.SequenceEquals(expectedObj.StringDict, actualObject.StringDict);
            testContext.SequenceEquals(expectedObj.EnumDict, actualObject.EnumDict);

            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void ArrayAsObject(UUnitTestContext testContext)
        {
            string json = "{\"Version\": \"2016-06-21_23-57-16\", \"ObjectArray\": [{\"Id\": 2, \"Name\": \"Stunned\", \"Type\": \"Condition\", \"ShowNumber\": true, \"EN_text\": \"Stunned\", \"EN_reminder\": \"Can\'t attack, block, or activate\"}, {\"Id\": 3, \"Name\": \"Poisoned\", \"Type\": \"Condition\", \"ShowNumber\": true, \"EN_text\": \"Poisoned\", \"EN_reminder\": \"Takes {N} damage at the start of each turn. Wears off over time.\" }], \"StringArray\": [\"NoSubtype\", \"Aircraft\"]}";
            var result = JsonWrapper.DeserializeObject<Dictionary<string, object>>(json);
            var version = result["Version"] as string;
            var objArray = result["ObjectArray"] as List<object>;
            var strArray = result["StringArray"] as List<object>;

            testContext.NotNull(result);
            testContext.True(!string.IsNullOrEmpty(version));
            testContext.True(objArray != null && objArray.Count > 0);
            testContext.True(strArray != null && strArray.Count > 0);

            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void TimeSpanJson(UUnitTestContext testContext)
        {
            TimeSpan span = TimeSpan.FromSeconds(5);
            string actualJson = JsonWrapper.SerializeObject(span, PlayFabUtil.ApiSerializerStrategy);
            string expectedJson = "5";
            testContext.StringEquals(expectedJson, actualJson, actualJson);

            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void ArrayOfObjects(UUnitTestContext testContext)
        {
            string actualJson = "[{\"a\":\"aValue\"}, {\"b\":\"bValue\"}]";
            var actualObjectList = JsonWrapper.DeserializeObject<List<object>>(actualJson);
            var actualObjectArray = JsonWrapper.DeserializeObject<object[]>(actualJson);

            testContext.IntEquals(actualObjectList.Count, 2);
            testContext.IntEquals(actualObjectArray.Length, 2);

            testContext.StringEquals(((JsonObject)actualObjectList[0])["a"] as string, "aValue");
            testContext.StringEquals(((JsonObject)actualObjectList[1])["b"] as string, "bValue");

            testContext.EndTest(UUnitFinishState.PASSED, null);
        }

        [UUnitTest]
        public void NullableJson(UUnitTestContext testContext)
        {
            var testObj = new NullableTestClass();
            var actualJson = JsonWrapper.SerializeObject(testObj, PlayFabUtil.ApiSerializerStrategy);
            var actualObj = JsonWrapper.DeserializeObject<NullableTestClass>(actualJson);

            testContext.IsNull(actualObj.IntField, "Nullable integer field does not serialize properly: " + testObj.IntField + ", from " + actualJson);
            testContext.IsNull(actualObj.IntProperty, "Nullable integer property does not serialize properly: " + testObj.IntProperty + ", from " + actualJson);
            testContext.IsNull(actualObj.TimeField, "Nullable struct field does not serialize properly: " + testObj.TimeField + ", from " + actualJson);
            testContext.IsNull(actualObj.TimeProperty, "Nullable struct property does not serialize properly: " + testObj.TimeProperty + ", from " + actualJson);
            testContext.IsNull(actualObj.EnumField, "Nullable enum field does not serialize properly: " + testObj.EnumField + ", from " + actualJson);
            testContext.IsNull(actualObj.EnumProperty, "Nullable enum property does not serialize properly: " + testObj.EnumProperty + ", from " + actualJson);

            testContext.EndTest(UUnitFinishState.PASSED, null);
        }
    }
}
