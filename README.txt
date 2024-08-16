translate these words
prespective , mentor ,bartenders ,automation engineer , doable  , feasible , 
==========================
over view :
Part 01:
00:20:00	what is different between api and microservice
00:21:15	what and why backend for front (BFF).
00:24:50	explanation about add balzor web app ( new .net8).
00:31:28	contents of blazor web app project .
00:31:38	managae static files (app.css and app.razor ) and adding all bootstrap , js and css .
00:35:35	manage routes (routes.razor ).
00:36:08	manage appsettings.json
00:40:00	install fit packages for manage identity( manage authentication users, roles etc).
00:45:24	create new database and adding connection string and talks about use one database for each servic in services orientation .
00:48:15	add new layer (AuthLayout.razor component ) for authenticated .
00:48:40	add blazm extesion for add commands to right menu ( add isolated css file or isolated js file or move namespace to							_imports.razor etc...).
00:51:40	prepare Authlayout with code, and discuss about redirect unauthenticated users to login page , also use @attribut							[AllowAnonymous] and adding	html and css codes .
00:59:43	add login component and select feature structure which contain feature folder which contains our pages ,then add new						_imports.razor to feature floder.
01:04:18	add Login.razor component then add editform to it .
01:07:30	make Login.razor not use the main layout but instead it uses the AuthLayout,also must allow to anonymouse to access it.
01:09:50	add .net aspire orchestrator support , and overview about AddServiceDefaults() which added to program.cs , also some features of			extensions.cs which built in by default when add aspire orchestrator
01:16:00	the new feature in blazor SupplyParameterFromForm , also talk about use many forms by use fromName attribute .
01:48:00	login functionality ( configue WebApplicationBuilder which include connection string , add extension about identity , configure				password  )
01:52:34	why we should use dbcontextfactoty before use dbcontext 
01:54:06	add identity configuration and discuss about how adding dbcontextfactory and then dbcontext and the problem which should to					warring about and add idnentitycore to customize usermanager to setup password and add service to manage Roles then add					servivce to manage signin , all of them in one extension then call this extension in (IOC)program.cs 
01:02:30	add extension to manage authentication to add certain authentication's services like (AddCascadingAuthenticationState) 
02:04:30	add mechanism to check regularly if a user still validate or not , so we must to add new service AuthStateRevalidation then					we'll add this service to the previous extension .
02:27:30	perform cookies authentication ( blazor part authentication ,also redirect to login ) , then add those services to program.cs ,				and test my project 
02:50:00	add functionality to add my account and add SuperAdmin role then make my account as superadmin at first login. 
03:18:20	add logout functionality.
=========================end part 1===============

================part 2===============
00:00:00	add NavMenue and IAmNavLink which contains routs for ( roles, teachers and students ) , explanation about using								<AuthorizeViewRole> and grant permession to Supeadmin Role , also explanation Routes.razor
01:34:50	add two components, one to add new role and second to view Roles list , here also use IServiceScopeFactory for dbcontext that				to avoid live dbcontext instant for last , we need to dispose it immediately after we don't use it anymore, we made that				at	01:45:00
02:26:00	solving problem that cause delay to move to the role page and there is delay in display hellow world , also test prerender					mode .
02:36:00	imelment conceret to add new role throgh blazor ssr 
=================part 3==============
00:00:00	create new api project to manage students , it takes longe time because some problems , it started at 01:10:00 , it talked about			we need microservices for every servives( student , grades , inrollment , etc) and also need communicate between services like			(when i create new student will be communications with other services like hey i created new specific student).
01:13:00	create domain folder to add entity , then add student model with its(propertis ,constructor , public behavior , private						behavior {claculate age }) , and then add address model , also add property for relationship between student and address,				then add relative model , and also add properties for relationship .
02:07:00	prepare migration , add student configuration , add approperiate libraries from nuget ,
02:27:00	add first migration for student project after add connectio string to program.cs
02:28:57	update database , and solve problem invariant culture is supported in globalization ( this problem appeared in dotnet8)
02:31:34	implement student endpoint , create student folder , then add mediatR from nuget , then create studentbase api controller which				all other api controller will inheritance from it , it contains mediatR, then we expose mediatR to other derrived						controller 
02:38:00	add create student controller ,with its implement and dtos
02:50:00	create student hendler and student command in the same file with mediatR
=====================part4==================
00:33:00	start to do backend for frontend with api minimal ,so we create endpoint that will get request come from webapplication and					redirected request to the student service and get information about a student and return it to our web application , so					we need a refit library and we need to create some API clients.
00:44:00	create api clients and install Refit.HttpClientfactoy and Refit libraries , then we create ISutdentsApiClient 


