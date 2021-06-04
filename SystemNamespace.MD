# C# 

## System Namespace

Contém classes fundamentais e classes base que definem tipos de dados de referência e valor usados com frequência, eventos e manipuladores de eventos, interfaces, atributos e exceções de processamento.

### CLASSES
- *AccessViolationException*	A exceção gerada quando há uma tentativa de ler ou gravar a memória protegida.
- *Activator*	Contém métodos para criar tipos de objetos localmente ou remotamente, ou obter referências a objetos remotos existentes. Essa classe não pode ser herdada.
- *AggregateException*	Representa um ou mais erros que ocorrem durante a execução do aplicativo.
- *AppContext*	Fornece membros para definir e recuperar dados sobre o contexto de um aplicativo.
- *AppDomain* Representa um domínio de aplicativo, que é um ambiente isolado em que os aplicativos são executados. Essa classe não pode ser herdada.
- *AppDomainSetup*Representa as informações de associação de assembly que podem ser adicionadas a uma instância de AppDomain.
- *AppDomainUnloadedException*A exceção lançada quando há uma tentativa de acessar um domínio de aplicativo descarregado.
- *ApplicationException*Serve como a classe base para exceções definidas pelo aplicativo.
- *ApplicationId*Contém informações usadas para identificar exclusivamente um aplicativo baseado em manifesto. Essa classe não pode ser herdada.
- *ApplicationIdentity* Fornece a capacidade de identificar com exclusividade um aplicativo ativado por manifesto. Essa classe não pode ser herdada.
- *ArgumentException* A exceção que é gerada quando um dos argumentos fornecidos para um método não é válido.
- *ArgumentNullException* A exceção que é gerada quando uma referência nula (Nothing no Visual Basic) é passada a um método que não a aceita como um argumento válido.
- *ArgumentOutOfRangeException* A exceção que é gerada quando o valor de um argumento está fora do intervalo permitido de valores conforme definido pelo método invocado.
- *ArithmeticException* A exceção que é gerada para erros em uma operação aritmética, projeção ou conversão.
- *Array * Fornece métodos para criar, manipular, pesquisar e classificar matrizes, servindo assim como a classe base para todas as matrizes no Common Language Runtime.
- *ArrayTypeMismatchException* A exceção que é gerada quando ocorre uma tentativa de armazenar um elemento do tipo errado em uma matriz.
- *AssemblyLoadEventArgs* Fornece dados para o evento de AssemblyLoad .
- *Attribute* Representa a classe base para os atributos personalizados.
- *AttributeUsageAttribute* Especifica o uso de outra classe de atributo. Essa classe não pode ser herdada.
- *BadImageFormatException* A exceção que é gerada quando a imagem do arquivo de uma DLL (biblioteca de vínculo dinâmico) ou um programa executável é inválida.
- *BitConverte* Converte tipos de dados para uma matriz de bytes e uma matriz de bytes para tipos de dados base de base.
- *Buffer* Manipula as matrizes de tipos primitivos.
CannotUnloadAppDomainException	
A exceção lançada quando uma tentativa de descarregar um domínio de aplicativo falha.
CharEnumerator	
Dá suporte à iteração em um objeto String e leitura de seus caracteres individuais. Essa classe não pode ser herdada.
CLSCompliantAttribute	
Indica se um elemento do programa é compatível com a CLS (Common Language Specification). Essa classe não pode ser herdada.
Console	
Representa os fluxos de entrada, saída e erro padrão para aplicativos de console. Essa classe não pode ser herdada.
ConsoleCancelEventArgs	
Fornece dados para o evento de CancelKeyPress . Essa classe não pode ser herdada.
ContextBoundObject	
Define a classe base para todas as classes associadas ao contexto.
ContextMarshalException	
A exceção gerada quando ocorre uma falha na tentativa de realizar marshaling de um objeto em um limite de contexto.
ContextStaticAttribute	
Indica que o valor de um campo estático é exclusivo para um contexto específico.
Convert	
Converte um tipo de dados base em outro tipo de dados base.
DataMisalignedException	
Exceção lançada quando uma unidade de dados é lida ou gravada em um endereço que não é múltiplo do tamanho dos dados. Essa classe não pode ser herdada.
DBNull	
Representa um valor inexistente. Essa classe não pode ser herdada.
Delegate	
Representa um representante que é uma estrutura de dados que faz referência a um método estático ou a uma classe e a um método de instância daquela classe.
DivideByZeroException	
A exceção que é gerada quando há uma tentativa de dividir um valor inteiro ou Decimal por zero.
DllNotFoundException	
A exceção que é lançada quando uma DLL especificada em uma importação de DLL não pode ser encontrada.
DuplicateWaitObjectException	
A exceção acionada quando um objeto é exibido mais de uma vez em uma matriz de objetos de sincronização.
EntryPointNotFoundException	
A exceção gerada quando ocorre falha ao tentar carregar uma classe devido a ausência de um método de entrada.
Enum	
Fornece a classe base para enumerações.
Environment	
Fornece informações sobre e significa que para manipular, o ambiente atual e a plataforma. Essa classe não pode ser herdada.
EventArgs	
Representa a classe base das classes que contêm dados de evento e fornece um valor a ser usado para eventos que não incluem dados de evento.
Exception	
Representa erros que ocorrem durante a execução do aplicativo.
ExecutionEngineException	
A exceção gerada quando ocorre um erro interno no mecanismo de execução do Common Language Runtime. Essa classe não pode ser herdada.
FieldAccessException	
A exceção que é lançada quando há uma tentativa inválida de acessar um campo particular ou protegido dentro de uma classe.
FileStyleUriParser	
Um analisador personalizável baseado no esquema de Arquivo.
FlagsAttribute	
Indica que uma enumeração pode ser tratada como um campo de bits; isto é, um conjunto de sinalizadores.
FormatException	
A exceção que é lançada quando o formato de um argumento é inválido ou quando uma cadeia de caracteres de formato de composição não está bem formada.
FormattableString	
Representa uma cadeia de caracteres de formato de composição, junto com os argumentos a serem formatados.
FtpStyleUriParser	
Um analisador personalizável baseado no esquema do protocolo FTP.
GC	
Controla o coletor de lixo do sistema, um serviço que recupera automaticamente a memória não utilizada.
GenericUriParser	
Um analisador personalizável para um URI hierárquico.
GopherStyleUriParser	
Um analisador personalizável baseado no esquema Gopher.
HttpStyleUriParser	
Um analisador personalizável baseado no esquema de HTTP.
IndexOutOfRangeException	
A exceção gerada quando ocorre uma tentativa de acessar um elemento de uma matriz ou coleção com um índice que está fora dos limites.
InsufficientExecutionStackException	
A exceção que é gerada quando há pilha de execução suficiente disponível para permitir a execução da maioria dos métodos.
InsufficientMemoryException	
A exceção lançada quando ocorre falha em uma verificação de memória suficiente disponível. Essa classe não pode ser herdada.
InvalidCastException	
A exceção que é gerada para projeção inválida ou conversão explícita.
InvalidOperationException	
A exceção que é gerada quando uma chamada de método é inválida para o estado atual do objeto.
InvalidProgramException	
A exceção que é gerada quando um programa contém código MSIL (Microsoft intermediate language) ou metadados. Isso normalmente indica um bug no compilador que gerou o programa.
InvalidTimeZoneException	
A exceção que é gerada quando informações de fuso horário são inválidas.
Lazy<T>	
Dá suporte à inicialização lenta.
Lazy<T,TMetadata>	
Fornece uma referência indireta lenta para um objeto e seus metadados associados para uso pelo Managed Extensibility Framework.
LdapStyleUriParser	
Um analisador personalizável com base no esquema do Protocolo LDAP (Lightweight Directory Access Protocol).
LoaderOptimizationAttribute	
Usado para definir a política de otimização do carregador padrão para o método principal de um aplicativo executável.
LocalDataStoreSlot	
Encapsula um slot de memória para armazenar dados locais. Essa classe não pode ser herdada.
MarshalByRefObject	
Permite acesso a objetos entre limites de domínio de aplicativo em aplicativos que dão suporte a comunicação remota.
Math	
Fornece constantes e métodos estáticos para trigonométricas, logarítmicas e outras funções matemáticas comuns.
MathF	
Fornece constantes e métodos estáticos para trigonométricas, logarítmicas e outras funções matemáticas comuns.
MemberAccessException	
A exceção lançada quando uma tentativa de acessar um membro da classe falha.
MemoryExtensions	
Fornece métodos de extensão para os tipos relacionados à memória e ao SPAN, como Memory<T> , ReadOnlyMemory<T> , Span<T> e ReadOnlySpan<T> .
MethodAccessException	
A exceção que é gerada quando há uma tentativa inválida de acessar um método como, por exemplo, acessar um método privado do código parcialmente confiável.
MissingFieldException	
A exceção que é gerada quando há uma tentativa de acessar dinamicamente um campo que não existe. Se um campo em uma biblioteca de classes tiver sido removido ou renomeado, recompile todos os assemblies que referenciam essa biblioteca.
MissingMemberException	
A exceção gerada quando há uma tentativa de acessar dinamicamente um membro de classe que não existe ou que não está declarado como público. Se um membro em uma biblioteca de classes tiver sido removido ou renomeado, recompile todos os assemblies referenciam essa biblioteca.
MissingMethodException	
A exceção que é gerada quando há uma tentativa de acessar dinamicamente um método que não existe.
MTAThreadAttribute	
Indica que o modelo de threading COM para um aplicativo é MTA (Multi-Threaded Apartment).
MulticastDelegate	
Representa um delegado de projeção múltipla, ou seja, um delegado que pode ter mais de um elemento na lista de invocação.
MulticastNotSupportedException	
A exceção gerada quando há uma tentativa de combinar dois delegados com base no tipo Delegate em vez do tipo MulticastDelegate. Essa classe não pode ser herdada.
NetPipeStyleUriParser	
Um analisador com base no esquema de NetPipe para o sistema "Indigo".
NetTcpStyleUriParser	
Um analisador com base no esquema de NetTcp para o sistema "Indigo".
NewsStyleUriParser	
Um analisador personalizável com base no esquema de notícias usando o protocolo NNTP.
NonSerializedAttribute	
Indica que um campo de uma classe serializável não deve ser serializado. Essa classe não pode ser herdada.
NotFiniteNumberException	
A exceção gerada quando um valor de ponto flutuante é infinito positivo, infinito negativo ou NaN (Não é um Número).
NotImplementedException	
A exceção que é lançada quando uma operação ou um método solicitado não é implementado.
NotSupportedException	
A exceção que é gerada quando um método invocado não tem suporte ou quando há uma tentativa de leitura, busca ou gravação em um fluxo que não dá suporte à funcionalidade invocada.
Nullable	
Dá suporte a um tipo de valor que pode receber null. Essa classe não pode ser herdada.
NullReferenceException	
A exceção que é gerada quando ocorre uma tentativa de desreferenciar um objeto de referência nula.
Object	
Dá suporte a todas as classes na hierarquia de classes do .NET e fornece serviços de baixo nível para as classes derivadas. Essa é a classe base final de todas as classes do .NET. É a raiz da hierarquia de tipo.
ObjectDisposedException	
A exceção que é gerada quando uma operação é executada em um objeto descartado.
ObsoleteAttribute	
Marca os elementos do programa que não estão mais em uso. Essa classe não pode ser herdada.
OperatingSystem	
Representa informações sobre um sistema operacional, como a versão e o identificador de plataforma. Essa classe não pode ser herdada.
OperationCanceledException	
A exceção que é gerada em um thread com o cancelamento de uma operação que o thread estava sendo executado.
OutOfMemoryException	
A exceção que é gerada quando não há memória suficiente para continuar a execução de um programa.
OverflowException	
A exceção que é gerada quando uma operação aritmética, projeção ou de conversão em um contexto verificado resulta em um estouro.
ParamArrayAttribute	
Indica que um método permitirá um número variável de argumentos na sua invocação. Essa classe não pode ser herdada.
PlatformNotSupportedException	
A exceção que é gerada quando um recurso não é executado em uma plataforma específica.
Progress<T>	
Fornece um IProgress<T> que invoca retornos de chamada para cada valor de progresso.
Random	
Representa um gerador de número pseudoaleatório, que é um algoritmo que produz uma sequência de números que atendem a certos requisitos estatísticos de aleatoriedade.
RankException	
A exceção que é gerada quando uma matriz com o número errado de dimensões é passada a um método.
ResolveEventArgs	
Fornece dados para eventos de resolução do carregador, como os eventos TypeResolve, ResourceResolve, ReflectionOnlyAssemblyResolve e AssemblyResolve.
SerializableAttribute	
Indica que uma classe pode ser serializada. Essa classe não pode ser herdada.
StackOverflowException	
A exceção gerada quando a pilha de execução estoura por conter chamadas de método aninhadas em excesso. Essa classe não pode ser herdada.
STAThreadAttribute	
Indica que o modelo de threading COM para um aplicativo é STA (Single-Threaded Apartment).
String	
Representa o texto como uma sequência de unidades de código UTF-16.
StringComparer	
Representa uma operação de comparação de cadeia de caracteres que usa regras de comparação ordinal ou com base em cultura e caso específico.
StringNormalizationExtensions	
Fornece métodos de extensão para trabalhar com normalização de cadeia de caracteres.
SystemException	
Funciona como a classe base para o namespace de exceções do sistema.
ThreadStaticAttribute	
Indica se o valor de um campo estático é exclusivo para cada thread.
TimeoutException	
Exceção lançada quando o tempo alocado para um processo ou uma operação tiver expirado.
TimeZone	
Representa um fuso horário.
TimeZoneInfo	
Representa qualquer fuso horário do mundo.
TimeZoneInfo.AdjustmentRule	
Fornece informações sobre um ajuste de fuso horário, como a transição do e para o horário de verão.
TimeZoneNotFoundException	
A exceção que é lançada quando um fuso horário não pode ser encontrado.
Tuple	
Fornece métodos estáticos para criar objetos de tupla.
Tuple<T1>	
Representa uma tupla de 1 ou unitária.
Tuple<T1,T2>	
Representa uma tupla de 2 ou par.
Tuple<T1,T2,T3>	
Representa uma tupla de 3 ou tripla.
Tuple<T1,T2,T3,T4>	
Representa uma tupla de 4 ou quádrupla.
Tuple<T1,T2,T3,T4,T5>	
Representa uma tupla 5 ou quíntupla.
Tuple<T1,T2,T3,T4,T5,T6>	
Representa uma tupla de 6 ou sêxtupla.
Tuple<T1,T2,T3,T4,T5,T6,T7>	
Representa uma tupla de 7 ou sétupla.
Tuple<T1,T2,T3,T4,T5,T6,T7,TRest>	
Representa uma tupla de n, em que n é 8 ou maior.
TupleExtensions	
Fornece métodos de extensão para que tuplas interoperem com suporte de linguagem para tuplas em C#.
Type	
Representa as declarações de tipo: tipos de classe, tipos de interface, tipos de matriz, tipos de valor, tipos de enumeração, parâmetros de tipo, definições de tipo genérico e tipos genéricos construídos abertos ou fechados.
TypeAccessException	
A exceção que é gerada quando um método tenta usar um tipo ao qual não tem acesso.
TypeInitializationException	
A exceção gerada como um wrapper em torno da exceção gerada pelo inicializador de classe. Essa classe não pode ser herdada.
TypeLoadException	
A exceção que é gerada quando ocorre uma falha de carregamento de tipos.
TypeUnloadedException	
A exceção lançada quando há uma tentativa de acessar uma classe descarregada.
UnauthorizedAccessException	
A exceção que é gerada quando o sistema operacional nega acesso devido a um erro de E/S ou de um tipo específico de erro de segurança.
UnhandledExceptionEventArgs	
Fornece dados para o evento gerado quando há uma exceção sem tratamento em um domínio de aplicativo.
Uri	
Fornece uma representação de objeto de um URI (Uniform Resource Identifier) e fácil acesso às partes do URI.
UriBuilder	
Fornece um construtor personalizado para URIs (Uniform Resource Identifiers) e modifica URIs para a classe Uri.
- *UriFormatException* A exceção que é gerada quando um URI inválido (URI) é detectado.
- *UriParser* Analisa um novo esquema de URI. Esta é uma classe abstrata.
- *UriTypeConverter* Converte um tipo String para um tipo Uri e vice-versa.
- *ValueType* Fornece a classe base para tipos de valor.
- *Version* Representa o número de versão de um assembly, sistema operacional ou do Common Language Runtime. Essa classe não pode ser herdada.
- *WeakReference* Representa uma referência fraca, que faz referência a um objeto enquanto ainda permite que esse objeto seja recuperada pela coleta de lixo.
- *WeakReference<T>* Representa uma referência fracamente tipada, que faz referência a um objeto enquanto ainda permite que esse objeto seja recuperada pela coleta de lixo.