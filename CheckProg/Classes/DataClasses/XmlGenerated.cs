using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CheckProg.Classes.DataClasses
{
    [XmlRoot(ElementName = "DataVersion")]
    public class DataVersion
    {
        [XmlElement(ElementName = "Machine")]
        public Machine Machine { get; set; }
        [XmlElement(ElementName = "Board")]
        public Board Board { get; set; }
        [XmlElement(ElementName = "Block")]
        public List<Block> Block { get; set; }
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "Machine")]
    public class Machine
    {
        [XmlAttribute(AttributeName = "Serial")]
        public string Serial { get; set; }
        [XmlAttribute(AttributeName = "LineName")]
        public string LineName { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "ViewX")]
        public string ViewX { get; set; }
        [XmlAttribute(AttributeName = "ViewY")]
        public string ViewY { get; set; }
        [XmlAttribute(AttributeName = "Lane")]
        public string Lane { get; set; }
    }

    [XmlRoot(ElementName = "Info")]
    public class Info
    {
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Side")]
        public string Side { get; set; }
        [XmlAttribute(AttributeName = "Length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "Width")]
        public string Width { get; set; }
        [XmlAttribute(AttributeName = "Thickness")]
        public string Thickness { get; set; }
        [XmlAttribute(AttributeName = "BlockNum")]
        public string BlockNum { get; set; }
        [XmlAttribute(AttributeName = "Path")]
        public string Path { get; set; }
    }

    [XmlRoot(ElementName = "Image")]
    public class Image
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "CropX1")]
        public string CropX1 { get; set; }
        [XmlAttribute(AttributeName = "CropY1")]
        public string CropY1 { get; set; }
        [XmlAttribute(AttributeName = "CropX2")]
        public string CropX2 { get; set; }
        [XmlAttribute(AttributeName = "CropY2")]
        public string CropY2 { get; set; }
        [XmlAttribute(AttributeName = "File")]
        public string File { get; set; }
    }

    [XmlRoot(ElementName = "Spc")]
    public class Spc
    {
        [XmlAttribute(AttributeName = "Use")]
        public string Use { get; set; }
        [XmlAttribute(AttributeName = "Path")]
        public string Path { get; set; }
        [XmlAttribute(AttributeName = "File")]
        public string File { get; set; }
    }

    [XmlRoot(ElementName = "Summary")]
    public class Summary
    {
        [XmlAttribute(AttributeName = "Path")]
        public string Path { get; set; }
    }

    [XmlRoot(ElementName = "Library")]
    public class Library
    {
        [XmlAttribute(AttributeName = "Root")]
        public string Root { get; set; }
    }

    [XmlRoot(ElementName = "ImageCollection")]
    public class ImageCollection
    {
        [XmlAttribute(AttributeName = "Mode")]
        public string Mode { get; set; }
        [XmlAttribute(AttributeName = "OkCollectionMAX")]
        public string OkCollectionMAX { get; set; }
        [XmlAttribute(AttributeName = "NgCollectionMAX")]
        public string NgCollectionMAX { get; set; }
        [XmlAttribute(AttributeName = "AutoDeleteMode")]
        public string AutoDeleteMode { get; set; }
    }

    [XmlRoot(ElementName = "InspParts")]
    public class InspParts
    {
        [XmlAttribute(AttributeName = "Num")]
        public string Num { get; set; }
    }

    [XmlRoot(ElementName = "NGImage")]
    public class NGImage
    {
        [XmlAttribute(AttributeName = "Folder")]
        public string Folder { get; set; }
    }

    [XmlRoot(ElementName = "QAOption")]
    public class QAOption
    {
        [XmlAttribute(AttributeName = "Use")]
        public string Use { get; set; }
        [XmlAttribute(AttributeName = "BoardName")]
        public string BoardName { get; set; }
    }

    [XmlRoot(ElementName = "Mobile")]
    public class Mobile
    {
        [XmlAttribute(AttributeName = "Use")]
        public string Use { get; set; }
    }

    [XmlRoot(ElementName = "NgMap")]
    public class NgMap
    {
        [XmlAttribute(AttributeName = "Use")]
        public string Use { get; set; }
        [XmlAttribute(AttributeName = "UpGood")]
        public string UpGood { get; set; }
        [XmlAttribute(AttributeName = "Good")]
        public string Good { get; set; }
        [XmlAttribute(AttributeName = "NG")]
        public string NG { get; set; }
        [XmlAttribute(AttributeName = "NonWork")]
        public string NonWork { get; set; }
        [XmlAttribute(AttributeName = "MapType")]
        public string MapType { get; set; }
    }

    [XmlRoot(ElementName = "Trace")]
    public class Trace
    {
        [XmlAttribute(AttributeName = "Cooperate")]
        public string Cooperate { get; set; }
        [XmlAttribute(AttributeName = "InspPair")]
        public string InspPair { get; set; }
    }

    [XmlRoot(ElementName = "BadmarkTransfer")]
    public class BadmarkTransfer
    {
        [XmlAttribute(AttributeName = "File")]
        public string File { get; set; }
    }

    [XmlRoot(ElementName = "Tok274")]
    public class Tok274
    {
        [XmlAttribute(AttributeName = "AutoBatchJudge")]
        public string AutoBatchJudge { get; set; }
    }

    [XmlRoot(ElementName = "Tok305")]
    public class Tok305
    {
        [XmlAttribute(AttributeName = "Line")]
        public string Line { get; set; }
        [XmlAttribute(AttributeName = "Machine")]
        public string Machine { get; set; }
    }

    [XmlRoot(ElementName = "Tok307")]
    public class Tok307
    {
        [XmlAttribute(AttributeName = "UDate")]
        public string UDate { get; set; }
        [XmlAttribute(AttributeName = "MchID")]
        public string MchID { get; set; }
        [XmlAttribute(AttributeName = "PCode")]
        public string PCode { get; set; }
        [XmlAttribute(AttributeName = "RcpNum")]
        public string RcpNum { get; set; }
        [XmlAttribute(AttributeName = "BGA1")]
        public string BGA1 { get; set; }
        [XmlAttribute(AttributeName = "BGA2")]
        public string BGA2 { get; set; }
        [XmlAttribute(AttributeName = "BGA3")]
        public string BGA3 { get; set; }
    }

    [XmlRoot(ElementName = "ProcessCheck")]
    public class ProcessCheck
    {
        [XmlAttribute(AttributeName = "Use")]
        public string Use { get; set; }
    }

    [XmlRoot(ElementName = "Tok315")]
    public class Tok315
    {
        [XmlAttribute(AttributeName = "InspBlk")]
        public string InspBlk { get; set; }
        [XmlAttribute(AttributeName = "BadBlk")]
        public string BadBlk { get; set; }
    }

    [XmlRoot(ElementName = "Tok433")]
    public class Tok433
    {
        [XmlAttribute(AttributeName = "SaveOkBlockData")]
        public string SaveOkBlockData { get; set; }
    }

    [XmlRoot(ElementName = "Option")]
    public class Option
    {
        [XmlElement(ElementName = "QAOption")]
        public QAOption QAOption { get; set; }
        [XmlElement(ElementName = "Mobile")]
        public Mobile Mobile { get; set; }
        [XmlElement(ElementName = "NgMap")]
        public NgMap NgMap { get; set; }
        [XmlElement(ElementName = "Trace")]
        public Trace Trace { get; set; }
        [XmlElement(ElementName = "BadmarkTransfer")]
        public BadmarkTransfer BadmarkTransfer { get; set; }
        [XmlElement(ElementName = "Tok274")]
        public Tok274 Tok274 { get; set; }
        [XmlElement(ElementName = "Tok305")]
        public Tok305 Tok305 { get; set; }
        [XmlElement(ElementName = "Tok307")]
        public Tok307 Tok307 { get; set; }
        [XmlElement(ElementName = "ProcessCheck")]
        public ProcessCheck ProcessCheck { get; set; }
        [XmlElement(ElementName = "Tok315")]
        public Tok315 Tok315 { get; set; }
        [XmlElement(ElementName = "Tok350")]
        public string Tok350 { get; set; }
        [XmlElement(ElementName = "Tok374")]
        public string Tok374 { get; set; }
        [XmlElement(ElementName = "Tok380")]
        public string Tok380 { get; set; }
        [XmlElement(ElementName = "Tok382")]
        public string Tok382 { get; set; }
        [XmlElement(ElementName = "Tok390")]
        public string Tok390 { get; set; }
        [XmlElement(ElementName = "Tok391")]
        public string Tok391 { get; set; }
        [XmlElement(ElementName = "Tok408")]
        public string Tok408 { get; set; }
        [XmlElement(ElementName = "Tok411")]
        public string Tok411 { get; set; }
        [XmlElement(ElementName = "Tok433")]
        public Tok433 Tok433 { get; set; }
    }

    [XmlRoot(ElementName = "FidPos")]
    public class FidPos
    {
        [XmlAttribute(AttributeName = "X")]
        public string X { get; set; }
        [XmlAttribute(AttributeName = "Y")]
        public string Y { get; set; }
        [XmlAttribute(AttributeName = "DetectX")]
        public string DetectX { get; set; }
        [XmlAttribute(AttributeName = "DetectY")]
        public string DetectY { get; set; }
    }

    [XmlRoot(ElementName = "Fiducial")]
    public class Fiducial
    {
        [XmlElement(ElementName = "FidPos")]
        public FidPos FidPos { get; set; }
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
    }

    [XmlRoot(ElementName = "Insp")]
    public class Insp
    {
        [XmlAttribute(AttributeName = "OperatorID")]
        public string OperatorID { get; set; }
        [XmlAttribute(AttributeName = "OperatorName")]
        public string OperatorName { get; set; }
        [XmlAttribute(AttributeName = "Result")]
        public string Result { get; set; }
        [XmlAttribute(AttributeName = "NGCount")]
        public string NGCount { get; set; }
        [XmlAttribute(AttributeName = "NGParts")]
        public string NGParts { get; set; }
        [XmlAttribute(AttributeName = "Time")]
        public string Time { get; set; }
    }

    [XmlRoot(ElementName = "First")]
    public class First
    {
        [XmlAttribute(AttributeName = "OperatorID")]
        public string OperatorID { get; set; }
        [XmlAttribute(AttributeName = "OperatorName")]
        public string OperatorName { get; set; }
        [XmlAttribute(AttributeName = "Result")]
        public string Result { get; set; }
        [XmlAttribute(AttributeName = "NGCount")]
        public string NGCount { get; set; }
        [XmlAttribute(AttributeName = "NGParts")]
        public string NGParts { get; set; }
        [XmlAttribute(AttributeName = "StartTime")]
        public string StartTime { get; set; }
        [XmlAttribute(AttributeName = "FinishTime")]
        public string FinishTime { get; set; }
    }

    [XmlRoot(ElementName = "Second")]
    public class Second
    {
        [XmlAttribute(AttributeName = "OperatorID")]
        public string OperatorID { get; set; }
        [XmlAttribute(AttributeName = "OperatorName")]
        public string OperatorName { get; set; }
        [XmlAttribute(AttributeName = "Result")]
        public string Result { get; set; }
        [XmlAttribute(AttributeName = "NGCount")]
        public string NGCount { get; set; }
        [XmlAttribute(AttributeName = "NGParts")]
        public string NGParts { get; set; }
        [XmlAttribute(AttributeName = "StartTime")]
        public string StartTime { get; set; }
        [XmlAttribute(AttributeName = "FinishTime")]
        public string FinishTime { get; set; }
    }

    [XmlRoot(ElementName = "Judge")]
    public class Judge
    {
        [XmlElement(ElementName = "Insp")]
        public Insp Insp { get; set; }
        [XmlElement(ElementName = "First")]
        public First First { get; set; }
        [XmlElement(ElementName = "Second")]
        public Second Second { get; set; }
    }

    [XmlRoot(ElementName = "Board")]
    public class Board
    {
        [XmlElement(ElementName = "Info")]
        public Info Info { get; set; }
        [XmlElement(ElementName = "Image")]
        public Image Image { get; set; }
        [XmlElement(ElementName = "Spc")]
        public Spc Spc { get; set; }
        [XmlElement(ElementName = "Summary")]
        public Summary Summary { get; set; }
        [XmlElement(ElementName = "Library")]
        public Library Library { get; set; }
        [XmlElement(ElementName = "ImageCollection")]
        public ImageCollection ImageCollection { get; set; }
        [XmlElement(ElementName = "InspParts")]
        public InspParts InspParts { get; set; }
        [XmlElement(ElementName = "NGImage")]
        public NGImage NGImage { get; set; }
        [XmlElement(ElementName = "Option")]
        public Option Option { get; set; }
        [XmlElement(ElementName = "Fiducial")]
        public List<Fiducial> Fiducial { get; set; }
        [XmlElement(ElementName = "Judge")]
        public Judge Judge { get; set; }
        [XmlAttribute(AttributeName = "Count")]
        public string Count { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Time")]
        public string Time { get; set; }
    }

    [XmlRoot(ElementName = "PartsImage")]
    public class PartsImage
    {
        [XmlAttribute(AttributeName = "ImageNameU")]
        public string ImageNameU { get; set; }
        [XmlAttribute(AttributeName = "ImageNameM")]
        public string ImageNameM { get; set; }
        [XmlAttribute(AttributeName = "ImageNameL")]
        public string ImageNameL { get; set; }
        [XmlAttribute(AttributeName = "ImageNameH")]
        public string ImageNameH { get; set; }
        [XmlAttribute(AttributeName = "ImageNameCI")]
        public string ImageNameCI { get; set; }
        [XmlAttribute(AttributeName = "Parts3dName")]
        public string Parts3dName { get; set; }
        [XmlAttribute(AttributeName = "OptSlant")]
        public string OptSlant { get; set; }
        [XmlAttribute(AttributeName = "OptSlantName045")]
        public string OptSlantName045 { get; set; }
        [XmlAttribute(AttributeName = "OptSlantName135")]
        public string OptSlantName135 { get; set; }
        [XmlAttribute(AttributeName = "OptSlantName225")]
        public string OptSlantName225 { get; set; }
        [XmlAttribute(AttributeName = "OptSlantName315")]
        public string OptSlantName315 { get; set; }
    }

    [XmlRoot(ElementName = "ImageRect")]
    public class ImageRect
    {
        [XmlAttribute(AttributeName = "CenterX")]
        public string CenterX { get; set; }
        [XmlAttribute(AttributeName = "CenterY")]
        public string CenterY { get; set; }
        [XmlAttribute(AttributeName = "SizeX")]
        public string SizeX { get; set; }
        [XmlAttribute(AttributeName = "SizeY")]
        public string SizeY { get; set; }
        [XmlAttribute(AttributeName = "OrgCenterX")]
        public string OrgCenterX { get; set; }
        [XmlAttribute(AttributeName = "OrgCenterY")]
        public string OrgCenterY { get; set; }
    }

    [XmlRoot(ElementName = "CropPos")]
    public class CropPos
    {
        [XmlAttribute(AttributeName = "X1")]
        public string X1 { get; set; }
        [XmlAttribute(AttributeName = "Y1")]
        public string Y1 { get; set; }
        [XmlAttribute(AttributeName = "X2")]
        public string X2 { get; set; }
        [XmlAttribute(AttributeName = "Y2")]
        public string Y2 { get; set; }
    }

    [XmlRoot(ElementName = "Area")]
    public class Area
    {
        [XmlAttribute(AttributeName = "X1")]
        public string X1 { get; set; }
        [XmlAttribute(AttributeName = "Y1")]
        public string Y1 { get; set; }
        [XmlAttribute(AttributeName = "X2")]
        public string X2 { get; set; }
        [XmlAttribute(AttributeName = "Y2")]
        public string Y2 { get; set; }
    }

    [XmlRoot(ElementName = "ImgCenter")]
    public class ImgCenter
    {
        [XmlAttribute(AttributeName = "X")]
        public string X { get; set; }
        [XmlAttribute(AttributeName = "Y")]
        public string Y { get; set; }
    }

    [XmlRoot(ElementName = "Tok322InspPos")]
    public class Tok322InspPos
    {
        [XmlAttribute(AttributeName = "PosX")]
        public string PosX { get; set; }
        [XmlAttribute(AttributeName = "PosY")]
        public string PosY { get; set; }
        [XmlAttribute(AttributeName = "SizeX")]
        public string SizeX { get; set; }
        [XmlAttribute(AttributeName = "SizeY")]
        public string SizeY { get; set; }
        [XmlAttribute(AttributeName = "Angle")]
        public string Angle { get; set; }
    }

    [XmlRoot(ElementName = "Pos")]
    public class Pos
    {
        [XmlAttribute(AttributeName = "X")]
        public string X { get; set; }
        [XmlAttribute(AttributeName = "Y")]
        public string Y { get; set; }
        [XmlAttribute(AttributeName = "Angle")]
        public string Angle { get; set; }
        [XmlAttribute(AttributeName = "SizeX")]
        public string SizeX { get; set; }
        [XmlAttribute(AttributeName = "SizeY")]
        public string SizeY { get; set; }
    }

    [XmlRoot(ElementName = "Median")]
    public class Median
    {
        [XmlAttribute(AttributeName = "Size")]
        public string Size { get; set; }
    }

    [XmlRoot(ElementName = "Ball")]
    public class Ball
    {
        [XmlAttribute(AttributeName = "Diameter")]
        public string Diameter { get; set; }
    }

    [XmlRoot(ElementName = "XRay")]
    public class XRay
    {
        [XmlAttribute(AttributeName = "LaminoSet")]
        public string LaminoSet { get; set; }
        [XmlAttribute(AttributeName = "NgImageTypeX")]
        public string NgImageTypeX { get; set; }
        [XmlAttribute(AttributeName = "Side")]
        public string Side { get; set; }
        [XmlAttribute(AttributeName = "CapPosOffX")]
        public string CapPosOffX { get; set; }
        [XmlAttribute(AttributeName = "CapPosOffY")]
        public string CapPosOffY { get; set; }
        [XmlAttribute(AttributeName = "HightCorrect")]
        public string HightCorrect { get; set; }
        [XmlAttribute(AttributeName = "SampHeight")]
        public string SampHeight { get; set; }
        [XmlAttribute(AttributeName = "XrayContUse")]
        public string XrayContUse { get; set; }
        [XmlAttribute(AttributeName = "XrayContHigh")]
        public string XrayContHigh { get; set; }
        [XmlAttribute(AttributeName = "XrayContLow")]
        public string XrayContLow { get; set; }
        [XmlAttribute(AttributeName = "XraySubtractModelLibStepNo")]
        public string XraySubtractModelLibStepNo { get; set; }
        [XmlAttribute(AttributeName = "XraySubtractOwnLibStepNo")]
        public string XraySubtractOwnLibStepNo { get; set; }
    }

    [XmlRoot(ElementName = "Height")]
    public class Height
    {
        [XmlAttribute(AttributeName = "CorrectType")]
        public string CorrectType { get; set; }
        [XmlAttribute(AttributeName = "LiftLimit")]
        public string LiftLimit { get; set; }
    }

    [XmlRoot(ElementName = "Thresh")]
    public class Thresh
    {
        [XmlAttribute(AttributeName = "Low1")]
        public string Low1 { get; set; }
        [XmlAttribute(AttributeName = "Up1")]
        public string Up1 { get; set; }
        [XmlAttribute(AttributeName = "Low2")]
        public string Low2 { get; set; }
        [XmlAttribute(AttributeName = "Up2")]
        public string Up2 { get; set; }
        [XmlAttribute(AttributeName = "Low3")]
        public string Low3 { get; set; }
        [XmlAttribute(AttributeName = "Up3")]
        public string Up3 { get; set; }
    }

    [XmlRoot(ElementName = "Param")]
    public class Param
    {
        [XmlElement(ElementName = "Pos")]
        public Pos Pos { get; set; }
        [XmlElement(ElementName = "Median")]
        public Median Median { get; set; }
        [XmlElement(ElementName = "Ball")]
        public Ball Ball { get; set; }
        [XmlElement(ElementName = "XRay")]
        public XRay XRay { get; set; }
        [XmlElement(ElementName = "Height")]
        public Height Height { get; set; }
        [XmlElement(ElementName = "Thresh")]
        public Thresh Thresh { get; set; }
    }

    [XmlRoot(ElementName = "CurPos")]
    public class CurPos
    {
        [XmlAttribute(AttributeName = "X")]
        public string X { get; set; }
        [XmlAttribute(AttributeName = "Y")]
        public string Y { get; set; }
        [XmlAttribute(AttributeName = "SizeX")]
        public string SizeX { get; set; }
        [XmlAttribute(AttributeName = "SizeY")]
        public string SizeY { get; set; }
    }

    [XmlRoot(ElementName = "Detect")]
    public class Detect
    {
        [XmlElement(ElementName = "CurPos")]
        public CurPos CurPos { get; set; }
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
    }

    [XmlRoot(ElementName = "Measure")]
    public class Measure
    {
        [XmlAttribute(AttributeName = "OffsetX")]
        public string OffsetX { get; set; }
        [XmlAttribute(AttributeName = "OffsetY")]
        public string OffsetY { get; set; }
        [XmlAttribute(AttributeName = "OffsetR")]
        public string OffsetR { get; set; }
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "Comment")]
        public string Comment { get; set; }
    }

    [XmlRoot(ElementName = "Result")]
    public class Result
    {
        [XmlAttribute(AttributeName = "First")]
        public string First { get; set; }
        [XmlAttribute(AttributeName = "FirstNGReason")]
        public string FirstNGReason { get; set; }
        [XmlAttribute(AttributeName = "FirstJudgeAction")]
        public string FirstJudgeAction { get; set; }
        [XmlAttribute(AttributeName = "Second")]
        public string Second { get; set; }
        [XmlAttribute(AttributeName = "SecondNGReason")]
        public string SecondNGReason { get; set; }
    }

    [XmlRoot(ElementName = "StepImage")]
    public class StepImage
    {
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "NGName")]
        public string NGName { get; set; }
        [XmlAttribute(AttributeName = "InspName")]
        public string InspName { get; set; }
    }

    [XmlRoot(ElementName = "LibImage")]
    public class LibImage
    {
        [XmlAttribute(AttributeName = "Sub")]
        public string Sub { get; set; }
    }

    [XmlRoot(ElementName = "Tok380Step")]
    public class Tok380Step
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Max")]
        public string Max { get; set; }
        [XmlAttribute(AttributeName = "Min")]
        public string Min { get; set; }
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "Unit")]
        public string Unit { get; set; }
    }

    [XmlRoot(ElementName = "Step")]
    public class Step
    {
        [XmlElement(ElementName = "CropPos")]
        public CropPos CropPos { get; set; }
        [XmlElement(ElementName = "Area")]
        public Area Area { get; set; }
        [XmlElement(ElementName = "ImgCenter")]
        public ImgCenter ImgCenter { get; set; }
        [XmlElement(ElementName = "Tok322InspPos")]
        public Tok322InspPos Tok322InspPos { get; set; }
        [XmlElement(ElementName = "Param")]
        public Param Param { get; set; }
        [XmlElement(ElementName = "Detect")]
        public Detect Detect { get; set; }
        [XmlElement(ElementName = "Measure")]
        public Measure Measure { get; set; }
        [XmlElement(ElementName = "Result")]
        public Result Result { get; set; }
        [XmlElement(ElementName = "StepImage")]
        public StepImage StepImage { get; set; }
        [XmlElement(ElementName = "LibImage")]
        public LibImage LibImage { get; set; }
        [XmlElement(ElementName = "Tok380Step")]
        public Tok380Step Tok380Step { get; set; }
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
        [XmlAttribute(AttributeName = "ViewNo")]
        public string ViewNo { get; set; }
        [XmlAttribute(AttributeName = "Status")]
        public string Status { get; set; }
        [XmlAttribute(AttributeName = "NGReason")]
        public string NGReason { get; set; }
        [XmlAttribute(AttributeName = "NGCode")]
        public string NGCode { get; set; }
        [XmlAttribute(AttributeName = "PinNo")]
        public string PinNo { get; set; }
        [XmlAttribute(AttributeName = "ResultType")]
        public string ResultType { get; set; }
        [XmlAttribute(AttributeName = "SubType")]
        public string SubType { get; set; }
        [XmlAttribute(AttributeName = "PartialType")]
        public string PartialType { get; set; }
        [XmlAttribute(AttributeName = "PinIndex")]
        public string PinIndex { get; set; }
        [XmlAttribute(AttributeName = "InspectType")]
        public string InspectType { get; set; }
        [XmlAttribute(AttributeName = "LclBadNo")]
        public string LclBadNo { get; set; }
        [XmlAttribute(AttributeName = "OwnDir")]
        public string OwnDir { get; set; }
    }

    [XmlRoot(ElementName = "Parts")]
    public class Parts
    {
        [XmlElement(ElementName = "PartsImage")]
        public PartsImage PartsImage { get; set; }
        [XmlElement(ElementName = "ImageRect")]
        public ImageRect ImageRect { get; set; }
        [XmlElement(ElementName = "Step")]
        public List<Step> Step { get; set; }
        [XmlAttribute(AttributeName = "RefNo")]
        public string RefNo { get; set; }
        [XmlAttribute(AttributeName = "Object")]
        public string Object { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Comment")]
        public string Comment { get; set; }
        [XmlAttribute(AttributeName = "LibName")]
        public string LibName { get; set; }
        [XmlAttribute(AttributeName = "LibParts")]
        public string LibParts { get; set; }
        [XmlAttribute(AttributeName = "X")]
        public string X { get; set; }
        [XmlAttribute(AttributeName = "Y")]
        public string Y { get; set; }
        [XmlAttribute(AttributeName = "Angle")]
        public string Angle { get; set; }
        [XmlAttribute(AttributeName = "SizeX")]
        public string SizeX { get; set; }
        [XmlAttribute(AttributeName = "SizeY")]
        public string SizeY { get; set; }
        [XmlAttribute(AttributeName = "RefDataNo")]
        public string RefDataNo { get; set; }
        [XmlAttribute(AttributeName = "PartsNo")]
        public string PartsNo { get; set; }
        [XmlAttribute(AttributeName = "RefAngle")]
        public string RefAngle { get; set; }
        [XmlAttribute(AttributeName = "RefX")]
        public string RefX { get; set; }
        [XmlAttribute(AttributeName = "RefY")]
        public string RefY { get; set; }
        [XmlAttribute(AttributeName = "NgImageSave")]
        public string NgImageSave { get; set; }
    }

    [XmlRoot(ElementName = "Block")]
    public class Block
    {
        [XmlElement(ElementName = "Parts")]
        public List<Parts> Parts { get; set; }
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
    }
}



