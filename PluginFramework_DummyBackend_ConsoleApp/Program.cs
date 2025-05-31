using PluginFramework_DummyBackend_ConsoleApp.DummyRepository;
using PluginFramework_DummyBackend_ConsoleApp.Models;
using PluginFramework_DummyBackend_ConsoleApp.Plugins;

var image1 = new Image() { Name = "Img1", FileFormat = "jpg", Size = new Size(5,5), BlurRadius = 12, IsGrayscale = false};
var image2 = new Image() { Name = "Img2", FileFormat = "jpg", Size = new Size(2,2), BlurRadius = 10, IsGrayscale = false};

Console.WriteLine("Old Images");
Console.WriteLine(image1.ToString());
Console.WriteLine(image2.ToString());

//dummy repo
var imageRepo = new ImagesRepository(new List<Image> { image1, image2 });

var dict = new Dictionary<Guid, List<Effect>>();

var sizeEffct = new SizeEffect() { Size = new Size(15, 15) };
var sizeEffctImg2 = new SizeEffect() { Size = new Size(10, 15) };
var blurEffect = new BlurEffect() { BlureRadius = 20 };
var grayscaleEffect = new Grayscale() { IsGrayscale = true };
var newEffect = new Effect() { ApplyEffect = sizeEffct };
var newEffectImg2 = new Effect() { ApplyEffect = sizeEffctImg2 };
var newEffect2Img2 = new Effect() { ApplyEffect = grayscaleEffect };
var newEffect2 = new Effect() { ApplyEffect = blurEffect };

dict.Add(image1.Id, new List<Effect?> { newEffect, newEffect2 });
dict.Add(image2.Id, new List<Effect?> { newEffectImg2, newEffect2Img2 });

var request = new ApplyEffectsRequest() { ImagesWithRequestedEffects = dict, ImagesRepository = imageRepo };

var imageProcessor = new ApplyPluginsProcessor();

//simulate backend call
//If had a time in real life will send a request dto to controller and handle according to response code 
imageProcessor.ProcessEffects(request);

Console.WriteLine("New Images");
Console.WriteLine(image1.ToString());
Console.WriteLine(image2.ToString());
Console.ReadLine();



