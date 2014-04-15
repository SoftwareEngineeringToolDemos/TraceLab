﻿<?xml version="1.0" encoding="utf-8"?>
<graph>
  <ExperimentInfo>
    <Version>1</Version>
    <Id>bedc1ef1-cddf-4771-9119-73d03868773d</Id>
    <Name>Preprocessor</Name>
    <LayoutName>EfficientSugiyama</LayoutName>
    <Author>RE Lab Team</Author>
    <Description>The experiment imports list of artifacts and stopwords, and preprocess them: cleans up characters, change all letters to lower case, removes stop words, and stem all terms to their root form.</Description>
  </ExperimentInfo>
  <node id="Start">
    <SerializedVertexData Version="1" X="199" Y="93">
      <Metadata type="TraceLab.Core.Components.StartNodeMetadata, TraceLab.Core, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151" Label="Start" />
    </SerializedVertexData>
  </node>
  <node id="End">
    <SerializedVertexData Version="1" X="241" Y="382">
      <Metadata type="TraceLab.Core.Components.EndNodeMetadata, TraceLab.Core, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151" Label="End" />
    </SerializedVertexData>
  </node>
  <node id="33a2b2e1-eace-47ab-8e00-8394668ca3e9">
    <SerializedVertexData Version="1" X="170" Y="155">
      <Metadata type="TraceLab.Core.Components.ComponentMetadata, TraceLab.Core, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151" Label="PoirotXMLImporter" ComponentMetadataDefinitionID="d98bd1e6-1db5-11e0-bfa9-3ee4dfd72085">
        <IOSpec Version="1">
          <Input />
          <Output />
          <Import>
            <ImportItem>
              <ImportItemDefinition Name="listOfArtifacts" Type="TraceLabSDK.Types.TLArtifactsCollection" />
              <ImportAs>originalListOfArtifacts</ImportAs>
            </ImportItem>
          </Import>
        </IOSpec>
        <ConfigWrapper Version="1" IsJava="False">
          <ConfigValues>
            <PropertyObject>
              <Version>2</Version>
              <Name>Path</Name>
              <DisplayName>Path</DisplayName>
              <ValueType>TraceLabSDK.Component.Config.FilePath, TraceLabSDK, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151</ValueType>
              <Visible>True</Visible>
              <Value>
                <FilePath>
                  <Version>1</Version>
                  <Relative>Data\challenge1_HIPPA\HIPPA\2CCHIT.xml</Relative>
                </FilePath>
              </Value>
            </PropertyObject>
          </ConfigValues>
        </ConfigWrapper>
      </Metadata>
    </SerializedVertexData>
  </node>
  <node id="f08bcd81-1e0d-4fd3-8b3d-75fb0d5f371b">
    <SerializedVertexData Version="1" X="168" Y="210">
      <Metadata type="TraceLab.Core.Components.ComponentMetadata, TraceLab.Core, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151" Label="Cleanup Preprocessor" ComponentMetadataDefinitionID="85cb9977-f2a6-426f-b3df-bb0cca26b276">
        <IOSpec Version="1">
          <Input>
            <InputItem>
              <InputItemDefinition Name="listOfArtifacts" Type="TraceLabSDK.Types.TLArtifactsCollection" />
              <MappedTo>originalListOfArtifacts</MappedTo>
            </InputItem>
          </Input>
          <Output>
            <OutputItem>
              <OutputItemDefinition Name="listOfArtifacts" Type="TraceLabSDK.Types.TLArtifactsCollection" />
              <OutputAs>listOfArtifacts</OutputAs>
            </OutputItem>
          </Output>
          <Import />
        </IOSpec>
        <ConfigWrapper Version="1" IsJava="False">
          <ConfigValues />
        </ConfigWrapper>
      </Metadata>
    </SerializedVertexData>
  </node>
  <node id="831682eb-4cc0-41b5-901f-be614917bca9">
    <SerializedVertexData Version="1" X="246" Y="276">
      <Metadata type="TraceLab.Core.Components.ComponentMetadata, TraceLab.Core, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151" Label="Stopwords Remover" ComponentMetadataDefinitionID="449f5e1f-b66e-4db1-ac70-ba0a0a54a3ba">
        <IOSpec Version="1">
          <Input>
            <InputItem>
              <InputItemDefinition Name="stopwords" Type="TraceLabSDK.Types.TLStopwords" />
              <MappedTo>stopwords</MappedTo>
            </InputItem>
            <InputItem>
              <InputItemDefinition Name="listOfArtifacts" Type="TraceLabSDK.Types.TLArtifactsCollection" />
              <MappedTo>listOfArtifacts</MappedTo>
            </InputItem>
          </Input>
          <Output>
            <OutputItem>
              <OutputItemDefinition Name="listOfArtifacts" Type="TraceLabSDK.Types.TLArtifactsCollection" />
              <OutputAs>listOfArtifacts</OutputAs>
            </OutputItem>
          </Output>
          <Import />
        </IOSpec>
        <ConfigWrapper Version="1" IsJava="False">
          <ConfigValues />
        </ConfigWrapper>
      </Metadata>
    </SerializedVertexData>
  </node>
  <node id="eda9d40f-09b9-4742-9810-211abaf23b5e">
    <SerializedVertexData Version="1" X="244" Y="330">
      <Metadata type="TraceLab.Core.Components.ComponentMetadata, TraceLab.Core, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151" Label="English Porter Stemmer" ComponentMetadataDefinitionID="420775e4-1afc-4142-9145-f32a7d1ed8c4">
        <IOSpec Version="1">
          <Input>
            <InputItem>
              <InputItemDefinition Name="listOfArtifacts" Type="TraceLabSDK.Types.TLArtifactsCollection" />
              <MappedTo>listOfArtifacts</MappedTo>
            </InputItem>
          </Input>
          <Output>
            <OutputItem>
              <OutputItemDefinition Name="listOfArtifacts" Type="TraceLabSDK.Types.TLArtifactsCollection" />
              <OutputAs>listOfArtifacts</OutputAs>
            </OutputItem>
          </Output>
          <Import />
        </IOSpec>
        <ConfigWrapper Version="1" IsJava="False">
          <ConfigValues />
        </ConfigWrapper>
      </Metadata>
    </SerializedVertexData>
  </node>
  <node id="1ef84c31-abc8-4f9e-aafb-a75a2bf87c50">
    <SerializedVertexData Version="1" X="362" Y="158">
      <Metadata type="TraceLab.Core.Components.ComponentMetadata, TraceLab.Core, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151" Label="StopwordsImporter" ComponentMetadataDefinitionID="b450dc72-1db6-11e0-bb91-fbe4dfd72085">
        <IOSpec Version="1">
          <Input />
          <Output />
          <Import>
            <ImportItem>
              <ImportItemDefinition Name="stopwords" Type="TraceLabSDK.Types.TLStopwords" />
              <ImportAs>stopwords</ImportAs>
            </ImportItem>
          </Import>
        </IOSpec>
        <ConfigWrapper Version="1" IsJava="False">
          <ConfigValues>
            <PropertyObject>
              <Version>2</Version>
              <Name>Path</Name>
              <DisplayName>Path</DisplayName>
              <ValueType>TraceLabSDK.Component.Config.FilePath, TraceLabSDK, Version=0.1.0.0, Culture=neutral, PublicKeyToken=2c83cea59a8bb151</ValueType>
              <Visible>True</Visible>
              <Value>
                <FilePath>
                  <Version>1</Version>
                  <Relative>Data\challenge1_HIPPA\HIPPA\stopwords.txt</Relative>
                </FilePath>
              </Value>
            </PropertyObject>
          </ConfigValues>
        </ConfigWrapper>
      </Metadata>
    </SerializedVertexData>
  </node>
  <edge id="fbbe318c-cdef-4297-b01a-3ff7daf90bf9" source="Start" target="33a2b2e1-eace-47ab-8e00-8394668ca3e9" />
  <edge id="ca71ee68-dd90-4037-9ad8-a7f9f74921b1" source="Start" target="1ef84c31-abc8-4f9e-aafb-a75a2bf87c50" />
  <edge id="e81b281d-49aa-4660-a166-0dfea6ca78a7" source="33a2b2e1-eace-47ab-8e00-8394668ca3e9" target="f08bcd81-1e0d-4fd3-8b3d-75fb0d5f371b" />
  <edge id="926c840c-5a73-4fc5-ab86-48d8e615bb05" source="f08bcd81-1e0d-4fd3-8b3d-75fb0d5f371b" target="831682eb-4cc0-41b5-901f-be614917bca9" />
  <edge id="79eef5e4-9f19-4320-a1ea-8f5b03b99536" source="831682eb-4cc0-41b5-901f-be614917bca9" target="eda9d40f-09b9-4742-9810-211abaf23b5e" />
  <edge id="392c853b-fb76-4a4c-b323-0d7e4060c2df" source="eda9d40f-09b9-4742-9810-211abaf23b5e" target="End" />
  <edge id="f8619bbc-4778-4e5f-bb7c-847b15e852de" source="1ef84c31-abc8-4f9e-aafb-a75a2bf87c50" target="831682eb-4cc0-41b5-901f-be614917bca9" />
</graph>