<h1 align="center"> Cache de memória no ASP.NET Core </h1>

<p align="center">
  <img src="https://user-images.githubusercontent.com/36374995/122860951-06553500-d2f5-11eb-960f-9d5fb94a4376.jpg" width="600">
</p>


## Como utilizar estrategia de cache nativa do.Net Core ? 

A implementação e muito simples,basta utilizar a interface IMemoryCache, observe na classe OAuthService,
armazenamos o token por 30 segundos em memoria, durante esse período o token de resposta será sempre o mesmo pós esse período o cache será destruído. 




> Essa aplicação e apenas uma demostração. 
