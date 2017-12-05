//Author: Jia Qi Lee (George) Date: 2017-11-15

var effectPlaying;
var backgroundPlaying;
var bgm = [
    { src: "content/sounds/bgm/OpeningTheme1.mp3"   , id: "content/sounds/bgm/OpeningTheme1.mp3"    },
    { src: "content/sounds/bgm/OpeningTheme2.mp3"   , id: "content/sounds/bgm/OpeningTheme2.mp3"    },
    { src: "content/sounds/bgm/PeaceTheme.mp3"      , id: "content/sounds/bgm/PeaceTheme.mp3"       },
    { src: "content/sounds/bgm/CampTheme.mp3", id: "content/sounds/bgm/CampTheme.mp3" },
    { src: "content/sounds/bgm/IliasTheme.mp3", id: "content/sounds/bgm/IliasTheme.mp3" },
    { src: "content/sounds/bgm/TravelTheme.mp3", id: "content/sounds/bgm/TravelTheme.mp3" },
    { src: "content/sounds/bgm/CrisisTheme.mp3", id: "content/sounds/bgm/CrisisTheme.mp3" },
    { src: "content/sounds/bgm/BattleTheme.mp3", id: "content/sounds/bgm/BattleTheme.mp3" },
    { src: "content/sounds/bgm/TownTheme.mp3", id: "content/sounds/bgm/TownTheme.mp3" },
    { src: "content/sounds/bgm/CastleTheme.mp3", id: "content/sounds/bgm/CastleTheme.mp3" },
    { src: "content/sounds/bgm/VillageTheme.mp3", id: "content/sounds/bgm/VillageTheme.mp3" },
    { src: "content/sounds/bgm/MysteryTheme.mp3", id: "content/sounds/bgm/MysteryTheme.mp3" },
    { src: "content/sounds/bgm/BossBuildUpTheme.mp3", id: "content/sounds/bgm/BossBuildUpTheme.mp3" },
    { src: "content/sounds/bgm/BossTheme.mp3", id: "content/sounds/bgm/BossTheme.mp3" },
    { src: "content/sounds/bgm/VictoryTheme.mp3", id: "content/sounds/bgm/VictoryTheme.mp3" },
];

var sfx = [
    { src: "content/sounds/sfx/explode.wav", id: "content/sounds/sfx/explode.wav" },
];

//Loads all the sounds into SoundJs
function loadSound()
{
    createjs.Sound.registerSounds(bgm);
    createjs.Sound.registerSounds(sfx);
}

//Plays a background sound
function playbgm(soundID)
{
    if (backgroundPlaying != null && backgroundPlaying.playState == "playSucceeded")
        backgroundPlaying.stop();
    var props = new createjs.PlayPropsConfig().set({ loop: -1 });
    console.log(props);
    console.log("Playing BGM: " + soundID);
    backgroundPlaying = createjs.Sound.play(soundID, props);
}

//Plays a sound effect
function playSound(soundID, loop) {
    if (effectPlaying != null && effectPlaying.playState == "playSucceeded")
        effectPlaying.stop();
    var props = new createjs.PlayPropsConfig().set({ loop: Number(loop) });
    console.log(props);
    console.log("Playing SFX: " + soundID);
    effectPlaying = createjs.Sound.play(soundID, props);
}

loadSound();

//SignalR setup code
$(function () {
    // Declare a proxy to reference the hub.
    var player = $.connection.soundPlayerHub;

    player.client.playSfx = function (sound, loop) {
        playSound(sound, loop);
    };

    player.client.playBackground = function (sound) {
        playbgm(sound);
    };

    // Start the connection
    $.connection.hub.logging = true;
    $.connection.hub.start().done(function () {
        // Call the Send method on the hub. 
        setTimeout(function () {
            player.server.registerClient();
        }, 1000);
    });
});

//Play the title theme
setTimeout(function () {
    playbgm("content/sounds/bgm/OpeningTheme1.mp3");
}, 4000);