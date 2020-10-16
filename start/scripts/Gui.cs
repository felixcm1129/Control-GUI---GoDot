using Godot;
using System;

public class Gui : MarginContainer
{
	private Label _numberLabel;
	private TextureProgress _bar;
	private Tween _tween;

	public override void _Ready()
	{
		_bar = (TextureProgress) GetNode("Bars/LifeBar/TextureProgress");
		_tween = (Tween) GetNode("Tween");
		_numberLabel = (Label) GetNode("Bars/LifeBar/Count/Background/Number");
		
		var player = (Player) GetNode("../Characters/Player");
		_bar.MaxValue = player.MaxHealth;
		
		
	}
	
	private void OnPlayerHealthChanged(int playerHealth)
	{
		UpdateHealth(playerHealth);
	}
	
	public void UpdateHealth(int health){
		_numberLabel.Text = health.ToString();
		_bar.Value = health;
	}
	
}






