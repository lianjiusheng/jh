using UnityEngine;
using System.Collections;

//关卡配置
public class ScenarioConfig  
{
	//大关卡ID
	public int TopScenarioId { get; set;}
	//小关卡ID
	private int ScenarioId { get; set;}
	//关卡名称
	private string ScenarioName { get; set;}
	//背景
	private string BgName { get; set;}
	//需求等级
	private int RequiredLvl { get; set;}
	//需要通过指定副本
	private int RequiredScenarioId { get; set;}
	//英雄
	private int[] HeroIds { get; set;}

}
