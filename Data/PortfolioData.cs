using HimelPortfolio.Models;

namespace HimelPortfolio.Data;

public static class PortfolioData
{
    // =========================================================================
    // 01. CORE PERSONAL & PROFESSIONAL IDENTITY
    // =========================================================================
    public const string BrandLogoText = "HIMEL";
    public const string FullName = "Habibur Rahman Himel";
    public const string PrimaryIdentity = "Software Engineer | .NET | AI";

    public static readonly IReadOnlyList<string> SupportingIdentities =
    [
        "Competitive Programmer",
        "Tech Content Creator",
        "AI Enthusiast"
    ];

    public const string HeroStemAnchor = "I LOVE";
    public const string HeroLine1 = "SOLVING PROBLEMS";
    public const string HeroLine2 = "BUILDING THINGS";
    public const string HeroLine3 = "EXPLORING TECH";
    public const string TopLine = "AS-SALAMU ALAYKUM · GLAD YOU'RE HERE";
    public const string TopLine2 = "FEEL FREE TO EXPLORE";
    public const string Location = "Bangladesh";
    public const string UniversityShort = "HSTU · ECE (3-II)";

    public const string CP = "Competitive Programmer";
    public const string TCC = "Tech Content Creator";
    public const string AI = "AI Enthusiast";
    public const string CurriculumPreviewUrl = "https://hstu.ac.bd/uploads/curriculam/ECE_curriculum_effective_from_the_Jan-Jun_2022.pdf"; 
    public const string HeroIntroduction =
        "Driven by curiosity about how technology works, evolves and connects the world around us. My primary focus is Software Engineering, particularly Backend and Full-Stack Engineering with C# and .NET, while exploring Artificial Intelligence, Machine Learning and Competitive Programming. Beyond coding, I also enjoy creating tech content and exploring custom PC builds and hardware through pcBhai !!";
    private const string _profileImagePath = "images/himel_profile1.jpg";

   
    public const string EmailAddress = "mdhabiburrahmanhimel27@gmail.com"; 
    public const string GitHubUrl = "https://github.com/Himel-HSTU"; 
    public const string LinkedInUrl = "https://www.linkedin.com/in/himel27"; 
    public const string YouTubeChannelUrl = "https://www.youtube.com/@pcBhai27"; 
    public const string FacebookPersonalUrl = "https://www.facebook.com/himelrahman27";
    public const string FacebookPageUrl = "https://www.facebook.com/pcBhai27"; 
    public const string FacebookGroupUrl = "https://www.facebook.com/groups/826468772379663"; 
    public const string FacebookGroupName = "pcBhai help and discussion";
    public const string ResumePdfPath = "/resume/Himel_Software_Engineer_Resume.pdf";
    public const bool IsResumePdfUploaded = false; // Set to true once you place your PDF in wwwroot/resume/

    // =========================================================================
    // 02. ABOUT ME PROSE
    // =========================================================================
    public static readonly IReadOnlyList<string> AboutParagraphs =
    [
        "I'm Habibur Rahman Himel, a Software Engineer focused on the C# & .NET ecosystem, backend engineering and building reliable software systems. I'm currently pursuing my undergraduate degree in B.Sc. (Engineering) in Electronics and Communication Engineering (ECE) at Hajee Mohammad Danesh Science and Technology University (HSTU), Dinajpur-5200, Bangladesh.",
        "My technical interests span both hardware and software. My ECE background has given me an understanding of computer hardware,  electronic systems and networking while my primary goal Software Engineering focus lies in C#, .NET and ASP.NET Core. I'm particularly interested in backend development, API design, software architecture and building practical applications. Alongside this, Competitive Programming has become an important part of my journey, helping me develop stronger algorithmic thinking and problem-solving skills.",
        "Beyond coding, I founded and run pcBhai, a technology education channel and custom PC-building venture in Bangladesh, with over 6,000 YouTube subscribers and 150+ published videos covering custom PC builds, hardware buying guides, and related tech topics. I also have hands-on experience assembling and delivering 100+ custom desktop PCs across different cities in Bangladesh.",
        "Running pcBhai has strengthened my communication, negotiation, and organizational skills through customer interactions, order management, and logistics. It has also taught me how to build trust, manage customer relationships, provide after-sales support, understand different perspectives, adapt to customer needs, and maintain quality while balancing business responsibilities with my studies.",
        "Currently, I'm exploring the intersection of Software Engineering and Artificial Intelligence. My current interests include Large Language Models (LLMs), Retrieval-Augmented Generation (RAG), and agentic AI workflows, with a focus on understanding how these technologies can be integrated into practical software systems.",
        "I believe in learning by building, exploring beyond familiar boundaries, and continuously improving through experimentation and real-world problem-solving."
    ];

    // =========================================================================
    // 03. EDUCATION TIMELINE
    // =========================================================================
    public static readonly IReadOnlyList<EducationEntry> EducationTimeline =
    [
        // 1. UNIVERSITY ENTRY (Full Details + Faculty + Coursework + Notes)
        new(
            Institution: "Hajee Mohammad Danesh Science and Technology University (HSTU)",
            Faculty: "Faculty of Computer Science and Engineering (CSE)",
            Department: "Department of Electronics and Communication Engineering (ECE)",
            DegreeName: "B.Sc. (Engineering) in Electronics and Communication Engineering",
            CurrentStageCode: "3-II",
            CurrentStageDescription: "Third-Year, Second Semester Undergraduate Student",
            EnrollmentYear: 2023,
            ExpectedGraduationYear: 2028,
            CgpaDisplay: null, // Leave null to hide, or set e.g. "3.XX / 4.00" when you choose to publish it
            RelevantCoursework:
            [
                "Artificial Intelligence & Neural Networks",
                "Data Structures & Algorithms",
                "Database Design & Management",
                "Web Engineering",
                "Cloud Computing Architecture",
                "Blockchain Technology",
                "Data Mining & Analytics",
                "Machine Learning & Pattern Recognition",
                "Object-Oriented Programming",
                "Computer Communications & Networks",
                "Information Theory and Coding",
                "Network Analysis and Inter-network Design",
                "Cryptography & Cyber Security",
                "System Analysis & Design",
                "Discrete Mathematics & Numerical Methods",
                "Computer Fundamentals & Structured Programming"
            ],
            AcademicNotes:
            [
                "Primarily focused on Software Engineering, while still enjoying the diverse world of Electronics and Communication Engineering.",
                "Actively involved in competitive programming, ICPC/IUPC activities, and programming sessions with seniors, fellow students and juniors.",
                "Enjoy exploring hardware projects, practical engineering concepts, and delivering academic and technical presentations.",
                "Research papers, academic journals, and thesis work are unexplored chapters. I'm looking forward to exploring soon."
            ]
        ),

        // 2. COLLEGE ENTRY (Compact — No Faculty, No Coursework, No Notes)
        new(
            Institution: "Dinajpur Government City College",
            Faculty: null,
            Department: "Class 11-12 · Science Group",
            DegreeName: "Higher Secondary Certificate (HSC)",
            CurrentStageCode: "HSC · 2022",
            CurrentStageDescription: "Completed Higher Secondary Education",
            EnrollmentYear: 2020,
            ExpectedGraduationYear: 2022,
            CgpaDisplay: "GPA 5.00 ",
            RelevantCoursework: [],
            AcademicNotes: []
        ),

        // 3. SCHOOL ENTRY (Compact — Class 3 to 10, No Faculty, No Coursework, No Notes)
        new(
            Institution: "Royal Residential School, Dinajpur",
            Faculty: null,
            Department: "Class 3-10 · Science Group",
            DegreeName: "Secondary School Certificate (SSC)",
            CurrentStageCode: "SSC · 2020",
            CurrentStageDescription: "Completed Secondary Education",
            EnrollmentYear: 2013,
            ExpectedGraduationYear: 2020,
            CgpaDisplay: "GPA 5.00 ",
            RelevantCoursework: [],
            AcademicNotes: []
        )
    ];

    // =========================================================================
    // 04. DYNAMIC TECHNICAL ARSENAL (CATEGORIES A — I)
    // =========================================================================



    public static readonly IReadOnlyList<SkillItem> Skills =
    [
        // A. Programming Languages
        new("C#", "A. Programming Languages", SkillStatus.WorkingWith,
        "Primary language for .NET application and backend engineering.", "https://learn.microsoft.com/en-us/dotnet/csharp/", 1),
    new("C++", "A. Programming Languages", SkillStatus.WorkingWith,
        "Competitive programming, data structures, algorithms, and problem-solving.", "https://isocpp.org/", 2),
    new("Python", "A. Programming Languages", SkillStatus.WorkingWith,
        "General-purpose programming, scripting, and AI experimentation.", "https://www.python.org/", 3),
    new("JavaScript", "A. Programming Languages", SkillStatus.WorkingWith,
        "Browser scripting and frontend development.", "https://developer.mozilla.org/en-US/docs/Web/JavaScript", 4),
    new("C", "A. Programming Languages", SkillStatus.FamiliarWith,
        "Structured programming and programming fundamentals.", null, 5),

    // B. Backend Engineering & .NET
    new(".NET", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Core platform for building modern, cross-platform applications.", "https://dotnet.microsoft.com/", 1),
    new("ASP.NET Core", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Framework for building web applications and backend services.", null, 2),
    new("ASP.NET Core Web API", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Building RESTful services and HTTP APIs.", null, 3),
    new("ASP.NET Core MVC", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Building web applications using the Model-View-Controller pattern.", null, 4),
    new("Minimal APIs", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Building lightweight HTTP APIs with ASP.NET Core.", null, 5),
    new("Entity Framework Core", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "ORM, LINQ queries, database modeling, and migrations.", null, 6),
    new("LINQ", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Querying and transforming data using Language Integrated Query.", null, 7),
    new("RESTful API Design", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Resource-oriented API design, HTTP methods, status codes, and endpoints.", null, 8),
    new("Dependency Injection", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Service registration, dependency resolution, and object lifetimes.", null, 9),
    new("Authentication & Authorization", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Managing user identity, access control, and protected resources.", null, 10),
    new("JWT Authentication", "B. Backend Engineering & .NET", SkillStatus.WorkingWith,
        "Token-based authentication and authorization workflows.", null, 11),
    new("Repository Pattern", "B. Backend Engineering & .NET", SkillStatus.FamiliarWith,
        "Separating data access logic from application logic.", null, 12),
    new("Auth0", "B. Backend Engineering & .NET", SkillStatus.FamiliarWith,
        "Identity and access management platform.", "https://auth0.com/", 13),
    new("Clean Architecture", "B. Backend Engineering & .NET", SkillStatus.FamiliarWith,
        "Organizing applications around separation of concerns and dependency boundaries.", null, 14),

    // C. Frontend Engineering
    new("HTML5", "C. Frontend Engineering", SkillStatus.WorkingWith,
        "Semantic markup and accessible web page structure.", null, 1),
    new("CSS3", "C. Frontend Engineering", SkillStatus.WorkingWith,
        "Responsive layouts, styling, and visual presentation.", null, 2),
    new("Blazor", "C. Frontend Engineering", SkillStatus.WorkingWith,
        "Building interactive web interfaces with C# and .NET.", null, 3),
    new("Razor Pages", "C. Frontend Engineering", SkillStatus.WorkingWith,
        "Page-focused web development with ASP.NET Core.", null, 4),
    new("Bootstrap", "C. Frontend Engineering", SkillStatus.WorkingWith,
        "Responsive UI development using a frontend component framework.", "https://getbootstrap.com/", 5),
    new("React", "C. Frontend Engineering", SkillStatus.FamiliarWith,
        "Component-based frontend development.", "https://react.dev/", 6),
    new("Next.js", "C. Frontend Engineering", SkillStatus.FamiliarWith,
        "React framework for building web applications.", "https://nextjs.org/", 7),
    new("Tailwind CSS", "C. Frontend Engineering", SkillStatus.FamiliarWith,
        "Utility-first CSS styling.", "https://tailwindcss.com/", 8),
    new("Angular", "C. Frontend Engineering", SkillStatus.Planned,
        "Frontend framework for building structured web applications.", "https://angular.dev/", 9),
    new("Vue.js", "C. Frontend Engineering", SkillStatus.Planned,
        "Progressive JavaScript framework for user interfaces.", "https://vuejs.org/", 10),

    // D. Databases & Data Management
    new("Microsoft SQL Server", "D. Databases & Data Management", SkillStatus.WorkingWith,
        "Relational database management for .NET applications.", null, 1),
    new("SQL", "D. Databases & Data Management", SkillStatus.WorkingWith,
        "Relational queries, joins, filtering, and data manipulation.", null, 2),
    new("PostgreSQL", "D. Databases & Data Management", SkillStatus.WorkingWith,
        "Open-source relational database management system.", "https://www.postgresql.org/", 3),
    new("Database Design", "D. Databases & Data Management", SkillStatus.WorkingWith,
        "Relational schema design, relationships, and data modeling.", null, 4),
    new("EF Core Migrations & Modeling", "D. Databases & Data Management", SkillStatus.WorkingWith,
        "Code-first database schema management and entity configuration.", null, 5),
    new("Database Normalization", "D. Databases & Data Management", SkillStatus.FamiliarWith,
        "Organizing relational data to reduce redundancy and improve integrity.", null, 6),
    new("Database Indexing & Optimization", "D. Databases & Data Management", SkillStatus.FamiliarWith,
        "Fundamentals of query performance and database indexing.", null, 7),
    new("DBeaver", "D. Databases & Data Management", SkillStatus.WorkingWith,
        "Database management and SQL development tool.", "https://dbeaver.io/", 8),
    new("Neon", "D. Databases & Data Management", SkillStatus.FamiliarWith,
        "Serverless PostgreSQL platform.", "https://neon.com/", 9),
    new("MongoDB", "D. Databases & Data Management", SkillStatus.Planned,
        "Document-oriented NoSQL database.", "https://www.mongodb.com/", 10),

    // E. Software Engineering Fundamentals
    new("Object-Oriented Programming", "E. Software Engineering Fundamentals", SkillStatus.WorkingWith,
        "Encapsulation, inheritance, polymorphism, and abstraction.", null, 1),
    new("Data Structures & Algorithms", "E. Software Engineering Fundamentals", SkillStatus.WorkingWith,
        "Algorithmic problem-solving, data structures, and complexity analysis.", null, 2),
    new("SOLID Principles", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Fundamental principles for maintainable object-oriented design.", null, 3),
    new("Design Patterns", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Common solutions to recurring software design problems.", null, 4),
    new("Software Development Life Cycle (SDLC)", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Understanding the stages of software planning, development, testing, and maintenance.", null, 5),
    new("Agile Methodology", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Iterative software development and adaptive project management.", null, 6),
    new("Scrum", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Agile framework based on roles, events, and iterative delivery.", null, 7),
    new("Waterfall Model", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Sequential approach to software development and project delivery.", null, 8),
    new("System Design", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Fundamentals of designing scalable and maintainable software systems.", null, 9),
    new("Software Testing", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Testing fundamentals, test cases, and software quality assurance.", null, 10),
    new("Unit & Integration Testing", "E. Software Engineering Fundamentals", SkillStatus.FamiliarWith,
        "Understanding isolated component testing and interactions between components.", null, 11),
    new("Debugging", "E. Software Engineering Fundamentals", SkillStatus.WorkingWith,
        "Identifying issues and tracing the root causes of software defects.", null, 12),
    new("Clean Code", "E. Software Engineering Fundamentals", SkillStatus.WorkingWith,
        "Writing readable, maintainable, and well-structured code.", null, 13),

    
    // F. Artificial Intelligence & Machine Learning
    new("Artificial Intelligence Fundamentals", "F. Artificial Intelligence & Machine Learning", SkillStatus.FamiliarWith,
        "Basic understanding of AI concepts, applications, and problem-solving approaches.", null, 1),
    new("Machine Learning Fundamentals", "F. Artificial Intelligence & Machine Learning", SkillStatus.FamiliarWith,
        "Getting familiar with core ML concepts, algorithms, and model training.", null, 2),
    new("Neural Networks & Deep Learning", "F. Artificial Intelligence & Machine Learning", SkillStatus.FamiliarWith,
        "Learning the fundamentals of neural networks and deep learning.", null, 3),
    new("Generative AI & Large Language Models", "F. Artificial Intelligence & Machine Learning", SkillStatus.FamiliarWith,
        "Understanding generative AI concepts, LLM capabilities, and practical applications.", null, 4),
    new("Prompt Engineering", "F. Artificial Intelligence & Machine Learning", SkillStatus.WorkingWith,
        "Crafting structured prompts and guiding AI models for useful outputs.", null, 5),
    new("Python for AI & Data Science", "F. Artificial Intelligence & Machine Learning", SkillStatus.FamiliarWith,
        "Exploring Python for AI, data processing, and machine learning workflows.", null, 6),
    new("AI Model APIs", "F. Artificial Intelligence & Machine Learning", SkillStatus.FamiliarWith,
        "Basic exposure to AI APIs and their integration into software applications.", null, 7),
    new("RAG & AI-Powered Applications", "F. Artificial Intelligence & Machine Learning", SkillStatus.Exploring,
        "An area of interest for building applications grounded in external knowledge and data.", null, 8),
    new("AI & ML Frameworks", "F. Artificial Intelligence & Machine Learning", SkillStatus.FamiliarWith,
        "Looking forward to exploring NumPy, Pandas, Scikit-learn, Matplotlib, PyTorch, and TensorFlow.", null, 9),


    // G. Cloud, DevOps & Deployment
    new("Application Deployment", "G. Cloud, DevOps & Deployment", SkillStatus.FamiliarWith,
        "Basic experience with publishing web applications and configuring deployments.", null, 1),
    new("Cloudflare", "G. Cloud, DevOps & Deployment", SkillStatus.FamiliarWith,
        "Basic exposure to DNS, domain management, and web infrastructure.", "https://www.cloudflare.com/", 2),
    new("Vercel", "G. Cloud, DevOps & Deployment", SkillStatus.FamiliarWith,
        "Frontend hosting and deployment platform.", "https://vercel.com/", 3),
    new("Netlify", "G. Cloud, DevOps & Deployment", SkillStatus.FamiliarWith,
        "Web hosting and deployment platform.", "https://www.netlify.com/", 4),
    new("Google Firebase", "G. Cloud, DevOps & Deployment", SkillStatus.FamiliarWith,
        "Backend-as-a-Service platform and application development tools.", "https://firebase.google.com/", 5),
    new("Cloud Computing Fundamentals", "G. Cloud, DevOps & Deployment", SkillStatus.FamiliarWith,
        "Basic understanding of cloud services, infrastructure, and deployment models.", null, 6),
    new("Docker", "G. Cloud, DevOps & Deployment", SkillStatus.Planned,
        "Containerization and reproducible application environments.", "https://www.docker.com/", 7),
    new("CI/CD", "G. Cloud, DevOps & Deployment", SkillStatus.Planned,
        "Automating software integration, testing, and delivery pipelines.", null, 8),
    new("GitHub Actions", "G. Cloud, DevOps & Deployment", SkillStatus.Planned,
        "Automating repository workflows and build pipelines.", "https://github.com/features/actions", 9),
    new("Kubernetes", "G. Cloud, DevOps & Deployment", SkillStatus.Planned,
        "Container orchestration and management.", "https://kubernetes.io/", 10),
    new("Microsoft Azure", "G. Cloud, DevOps & Deployment", SkillStatus.Planned,
        "Cloud platform for hosting and managing application infrastructure.", "https://azure.microsoft.com/", 11),
    new("AWS", "G. Cloud, DevOps & Deployment", SkillStatus.Planned,
        "Cloud computing platform and infrastructure services.", "https://aws.amazon.com/", 12),

    // H. Development Tools & Platforms
    new("Git", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        "Version control, branching, and source code management.", "https://git-scm.com/", 1),
    new("GitHub", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        "Code hosting, repository management, and collaboration.", "https://github.com/", 2),
    new("Visual Studio", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        "Primary IDE for C# and .NET development.", null, 3),
    new("Visual Studio Code", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        "Code editor for programming and development workflows.", "https://code.visualstudio.com/", 4),
    new("Linux", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        "Linux Mint environment and command-line workflows.", null, 5),
    new("Windows", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        "Windows development environment and system administration basics.", null, 6),
    new("Postman", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        "API testing, request collections, and environment management.", "https://www.postman.com/", 7),
    new("Swagger & OpenAPI", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        "API documentation, specifications, and interactive testing.", null, 8),
    new("NuGet", "H. Development Tools & Platforms", SkillStatus.WorkingWith,
        ".NET package management.", "https://www.nuget.org/", 9),
    new("npm", "H. Development Tools & Platforms", SkillStatus.FamiliarWith,
        "JavaScript package management and frontend tooling.", "https://www.npmjs.com/", 10),
    new("WSL", "H. Development Tools & Platforms", SkillStatus.FamiliarWith,
        "Windows Subsystem for Linux.", "https://learn.microsoft.com/en-us/windows/wsl/", 11)
    ];


    /* public static readonly IReadOnlyList<SkillItem> Skills =
     [
         // A. Programming Languages
         new("C#", "A. Programming Languages", SkillStatus.WorkingWith, "Primary language for backend architecture and web systems.", "https://learn.microsoft.com/en-us/dotnet/csharp/", 1),
         new("C++", "A. Programming Languages", SkillStatus.WorkingWith, "Primary language for competitive programming and STL algorithms.", "https://isocpp.org/", 2),
         new("C", "A. Programming Languages", SkillStatus.FamiliarWith, "Structured programming and hardware-level fundamentals.", null, 3),
         new("Python", "A. Programming Languages", SkillStatus.FamiliarWith, "Used for automation, OpenCV/MediaPipe systems, and AI experimentation.", "https://www.python.org/", 4),
         new("JavaScript", "A. Programming Languages", SkillStatus.FamiliarWith, "Browser scripting and frontend interactivity.", "https://developer.mozilla.org/en-US/docs/Web/JavaScript", 5),

         // B. Backend Engineering — .NET Ecosystem
         new(".NET / .NET Core", "B. Backend Engineering — .NET Ecosystem", SkillStatus.WorkingWith, "Core runtime and SDK for modern cross-platform software engineering.", "https://dotnet.microsoft.com/", 1),
         new("ASP.NET Core", "B. Backend Engineering — .NET Ecosystem", SkillStatus.WorkingWith, "Web framework for building web applications and services.", null, 2),
         new("ASP.NET Core Web API", "B. Backend Engineering — .NET Ecosystem", SkillStatus.WorkingWith, "RESTful HTTP services, controllers, and minimal APIs.", null, 3),
         new("ASP.NET Core MVC", "B. Backend Engineering — .NET Ecosystem", SkillStatus.FamiliarWith, "Model-View-Controller pattern in .NET.", null, 4),
         new("Entity Framework Core", "B. Backend Engineering — .NET Ecosystem", SkillStatus.WorkingWith, "ORM for relational data access, migrations, and LINQ queries.", null, 5),
         new("LINQ", "B. Backend Engineering — .NET Ecosystem", SkillStatus.WorkingWith, "Language Integrated Query for declarative data manipulation.", null, 6),
         new("RESTful API Development", "B. Backend Engineering — .NET Ecosystem", SkillStatus.WorkingWith, "Resource modeling, status semantics, and contract design.", null, 7),
         new("Dependency Injection", "B. Backend Engineering — .NET Ecosystem", SkillStatus.WorkingWith, "IoC container lifetimes and decoupled service registration.", null, 8),
         new("Authentication & Authorization", "B. Backend Engineering — .NET Ecosystem", SkillStatus.FamiliarWith, "Identity, role-based access, and endpoint security.", null, 9),
         new("JWT", "B. Backend Engineering — .NET Ecosystem", SkillStatus.FamiliarWith, "Stateless token-based authentication flows.", null, 10),
         new("Repository Pattern", "B. Backend Engineering — .NET Ecosystem", SkillStatus.FamiliarWith, "Data access abstraction and persistence separation.", null, 11),
         new("Clean Architecture", "B. Backend Engineering — .NET Ecosystem", SkillStatus.CurrentlyLearning, "Domain-centric layered backend organization.", null, 12),
         new("SignalR", "B. Backend Engineering — .NET Ecosystem", SkillStatus.Planned, "Real-time bidirectional communication.", null, 13),
         new("Redis", "B. Backend Engineering — .NET Ecosystem", SkillStatus.Planned, "Distributed caching and in-memory data structures.", null, 14),
         new("Background Services", "B. Backend Engineering — .NET Ecosystem", SkillStatus.Exploring, "IHostedService and asynchronous worker queues.", null, 15),
         new("gRPC", "B. Backend Engineering — .NET Ecosystem", SkillStatus.Planned, "High-performance RPC framework.", null, 16),
         new("Microservices", "B. Backend Engineering — .NET Ecosystem", SkillStatus.Planned, "Distributed service decomposition.", null, 17),

         // C. Frontend Engineering
         new("HTML5", "C. Frontend Engineering", SkillStatus.WorkingWith, "Semantic document structure and accessibility landmarks.", null, 1),
         new("CSS3", "C. Frontend Engineering", SkillStatus.WorkingWith, "Custom grid systems, responsive layouts, and design tokens.", null, 2),
         new("Blazor", "C. Frontend Engineering", SkillStatus.WorkingWith, "Component-driven C# web UI with Blazor WebAssembly.", null, 3),
         new("Razor Pages", "C. Frontend Engineering", SkillStatus.FamiliarWith, "Server-rendered page-focused .NET UI.", null, 4),
         new("React", "C. Frontend Engineering", SkillStatus.FamiliarWith, "Component-based frontend pairing for .NET Web APIs.", null, 5),
         new("Tailwind CSS", "C. Frontend Engineering", SkillStatus.FamiliarWith, "Utility-first styling workflow.", null, 6),
         new("Next.js", "C. Frontend Engineering", SkillStatus.Exploring, "React framework exploration.", null, 7),
         new("Angular", "C. Frontend Engineering", SkillStatus.Planned, "Enterprise TypeScript frontend framework.", null, 8),

         // D. Databases and Data Management
         new("Microsoft SQL Server", "D. Databases & Data Management", SkillStatus.WorkingWith, "Primary relational database for .NET backend systems.", null, 1),
         new("SQL", "D. Databases & Data Management", SkillStatus.WorkingWith, "Relational querying, joins, and schema design.", null, 2),
         new("PostgreSQL", "D. Databases & Data Management", SkillStatus.FamiliarWith, "Open-source relational database system.", null, 3),
         new("Database Normalization", "D. Databases & Data Management", SkillStatus.FamiliarWith, "Relational schema integrity (1NF–3NF/BCNF).", null, 4),
         new("EF Core Migrations & Modeling", "D. Databases & Data Management", SkillStatus.WorkingWith, "Code-first schema evolution and fluent configuration.", null, 5),
         new("DBeaver", "D. Databases & Data Management", SkillStatus.FamiliarWith, "Cross-platform database administration client.", null, 6),
         new("Neon", "D. Databases & Data Management", SkillStatus.Exploring, "Serverless PostgreSQL hosting.", null, 7),
         new("Database Indexing & Optimization", "D. Databases & Data Management", SkillStatus.CurrentlyLearning, "Query execution plans and index tuning.", null, 8),
         new("pgvector", "D. Databases & Data Management", SkillStatus.Exploring, "Vector similarity search inside PostgreSQL.", null, 9),
         new("MongoDB", "D. Databases & Data Management", SkillStatus.Planned, "Document database store.", null, 10),

         // E. API Development and Testing Tools
         new("Postman", "E. API Development & Testing Tools", SkillStatus.WorkingWith, "API request testing, collections, and environment validation.", null, 1),
         new("Swagger", "E. API Development & Testing Tools", SkillStatus.WorkingWith, "Interactive API documentation and endpoint testing.", null, 2),
         new("OpenAPI", "E. API Development & Testing Tools", SkillStatus.WorkingWith, "Standardized HTTP API specification in .NET.", null, 3),

         // F. Development Environment and Tools
         new("Visual Studio", "F. Development Environment & Tools", SkillStatus.WorkingWith, "Integrated IDE for C# and .NET solutions.", null, 1),
         new("Visual Studio Code", "F. Development Environment & Tools", SkillStatus.WorkingWith, "Lightweight editor on Linux Mint and Windows.", null, 2),
         new("Git", "F. Development Environment & Tools", SkillStatus.WorkingWith, "Distributed version control and branching workflows.", null, 3),
         new("GitHub", "F. Development Environment & Tools", SkillStatus.WorkingWith, "Source code hosting and collaboration.", null, 4),
         new("Linux", "F. Development Environment & Tools", SkillStatus.WorkingWith, "Daily driver OS (Linux Mint dual-boot) and CLI workflow.", null, 5),
         new("Windows", "F. Development Environment & Tools", SkillStatus.WorkingWith, ".NET development and hardware diagnostics environment.", null, 6),
         new("NuGet", "F. Development Environment & Tools", SkillStatus.WorkingWith, ".NET package management.", null, 7),
         new("npm", "F. Development Environment & Tools", SkillStatus.FamiliarWith, "Frontend package tooling.", null, 8),
         new("Docker", "F. Development Environment & Tools", SkillStatus.CurrentlyLearning, "Containerized development environments.", null, 9),
         new("GitHub Actions", "F. Development Environment & Tools", SkillStatus.Exploring, "Automated build and deployment workflows.", null, 10),
         new("WSL", "F. Development Environment & Tools", SkillStatus.FamiliarWith, "Windows Subsystem for Linux.", null, 11),
         new("Azure DevOps", "F. Development Environment & Tools", SkillStatus.Planned, "Enterprise lifecycle and pipeline management.", null, 12),

         // G. Software Engineering Concepts
         new("Object-Oriented Programming", "G. Software Engineering Concepts", SkillStatus.WorkingWith, "Encapsulation, polymorphism, abstractions, and interfaces.", null, 1),
         new("SOLID Principles", "G. Software Engineering Concepts", SkillStatus.WorkingWith, "Maintainable object-oriented software design.", null, 2),
         new("Data Structures & Algorithms", "G. Software Engineering Concepts", SkillStatus.WorkingWith, "Arrays, trees, graphs, sorting, searching, and complexity analysis.", null, 3),
         new("REST API Design", "G. Software Engineering Concepts", SkillStatus.WorkingWith, "Clean URI routing, pagination, and error envelopes.", null, 4),
         new("Version Control", "G. Software Engineering Concepts", SkillStatus.WorkingWith, "Structured commits and repository hygiene.", null, 5),
         new("Debugging", "G. Software Engineering Concepts", SkillStatus.WorkingWith, "Breakpoints, call-stack inspection, and root-cause isolation.", null, 6),
         new("Clean Code", "G. Software Engineering Concepts", SkillStatus.WorkingWith, "Readable naming, small functions, and clear intent.", null, 7),
         new("Design Patterns", "G. Software Engineering Concepts", SkillStatus.FamiliarWith, "Creational, structural, and behavioral patterns in C#.", null, 8),
         new("Software Testing", "G. Software Engineering Concepts", SkillStatus.CurrentlyLearning, "Automated verification and testability.", null, 9),
         new("System Design", "G. Software Engineering Concepts", SkillStatus.CurrentlyLearning, "Scalability, caching, and database partitioning fundamentals.", null, 10),
         new("Unit Testing", "G. Software Engineering Concepts", SkillStatus.CurrentlyLearning, "xUnit / NUnit test suites for business logic.", null, 11),
         new("Integration Testing", "G. Software Engineering Concepts", SkillStatus.Exploring, "Testing API endpoints and database persistence.", null, 12),
         new("Domain-Driven Design", "G. Software Engineering Concepts", SkillStatus.Planned, "Bounded contexts and rich domain models.", null, 13),
         new("Distributed Systems", "G. Software Engineering Concepts", SkillStatus.Planned, "Consistency, messaging, and fault tolerance.", null, 14),

         // H. Artificial Intelligence and Generative AI (Emerging Area of Technical Interest)
         new("Python for AI", "H. Artificial Intelligence & Generative AI", SkillStatus.CurrentlyLearning, "Scripting data pipelines and model inference in Python.", null, 1),
         new("Generative AI", "H. Artificial Intelligence & Generative AI", SkillStatus.Exploring, "Text, code, and multimodal synthesis workflows.", null, 2),
         new("Large Language Models (LLMs)", "H. Artificial Intelligence & Generative AI", SkillStatus.CurrentlyLearning, "Transformer capabilities, context windows, and structured outputs.", null, 3),
         new("Prompt Engineering", "H. Artificial Intelligence & Generative AI", SkillStatus.FamiliarWith, "System prompts, few-shot conditioning, and schema enforcement.", null, 4),
         new("AI APIs (Gemini / OpenAI)", "H. Artificial Intelligence & Generative AI", SkillStatus.Exploring, "Integrating LLM endpoints into software applications.", null, 5),
         new("Retrieval-Augmented Generation (RAG)", "H. Artificial Intelligence & Generative AI", SkillStatus.Exploring, "Grounding LLM responses over custom document corpora.", null, 6),
         new("Embeddings & Vector Databases", "H. Artificial Intelligence & Generative AI", SkillStatus.Exploring, "Semantic indexing and cosine similarity retrieval.", null, 7),
         new("AI Agents & Agentic Workflows", "H. Artificial Intelligence & Generative AI", SkillStatus.Exploring, "Tool-calling loops and multi-step reasoning.", null, 8),
         new("Model Context Protocol (MCP)", "H. Artificial Intelligence & Generative AI", SkillStatus.Exploring, "Standardized context and tool connectivity for LLMs.", null, 9),
         new("Microsoft Semantic Kernel", "H. Artificial Intelligence & Generative AI", SkillStatus.Exploring, ".NET-native SDK for orchestrating AI plugins and models.", null, 10),
         new("Ollama", "H. Artificial Intelligence & Generative AI", SkillStatus.Exploring, "Running local open-weight models.", null, 11),

         // I. Cloud, Deployment and DevOps
         new("Vercel", "I. Cloud, Deployment & DevOps", SkillStatus.FamiliarWith, "Static and frontend deployment workflows.", null, 1),
         new("Netlify", "I. Cloud, Deployment & DevOps", SkillStatus.FamiliarWith, "Static web hosting and continuous deployment.", null, 2),
         new("Application Deployment", "I. Cloud, Deployment & DevOps", SkillStatus.FamiliarWith, "Publishing production builds and configuring custom domains.", null, 3),
         new("Cloud Fundamentals", "I. Cloud, Deployment & DevOps", SkillStatus.CurrentlyLearning, "Compute, storage, and networking basics.", null, 4),
         new("CI/CD", "I. Cloud, Deployment & DevOps", SkillStatus.Exploring, "Automated build and deployment pipelines.", null, 5),
         new("Microsoft Azure", "I. Cloud, Deployment & DevOps", SkillStatus.Exploring, "Cloud ecosystem for .NET workloads.", null, 6),
         new("AWS", "I. Cloud, Deployment & DevOps", SkillStatus.Planned, "Amazon Web Services infrastructure.", null, 7)
     ];
    */

    // =========================================================================
    // 05. FEATURED PROJECTS (REGRETBOOK, HSTU CLUBBIES, HSTU ALUMNIBOOK)
    // =========================================================================
    public static readonly IReadOnlyList<ProjectItem> Projects =
    [

new(
    Slug: "regretbook",
    Title: "RegretBook",
    Tagline: "A Place to Let Your Regrets Out.",
    Category: "Full-Stack .NET Application / Modular Architecture",
    Status: ProjectStatus.InProgress,

    ShortDescription: "An anonymous social platform where people can share personal regrets, guilt, mistakes, and unspoken thoughts without revealing their identity.",

    ProblemStatement: "Many people carry personal regrets, guilt, and unresolved thoughts but hesitate to express them due to fear of judgment, social pressure, or privacy concerns. There is a need for a space where individuals can express these feelings without attaching their real-world identity.",

    Motivation: "Everyone has something they wish they had done differently — words left unsaid, decisions they regret, or mistakes they cannot easily share. RegretBook aims to provide a judgment-free space where people can let those feelings out, knowing they don't have to reveal who they are.",

    ProposedSolution: "RegretBook provides an anonymous platform for publishing personal reflections, exploring others' experiences, and engaging through supportive interactions without exposing personal identities.",

    ArchitectureOverview: "A full-stack application with a Next.js frontend communicating with an ASP.NET Core Web API backend. The backend handles application logic, data validation, authentication or identity management where required, and persistence through Entity Framework Core and SQL Server.",

    TechStack:
    [
        "C#",
        "ASP.NET Core Web API",
        "Entity Framework Core",
        "SQL Server",
        "REST API",
        "Next.js"
    ],

    EngineeringDecisions:
    [
        "Design an anonymous publishing model that separates public identity from personal reflections.",
        "Structure API endpoints and request/response contracts for consistent communication between frontend and backend.",
        "Apply server-side validation and controlled data access to protect user privacy."
    ],

    Challenges:
    [
        "[To be documented as actual development challenges once encountered.]"
    ],

    FutureImprovements:
    [
        "Semantic search and AI-assisted reflection categorization.",
        "Enhanced content moderation.",
        "Personal reflection export capabilities."
    ],

    GitHubUrl: "https://github.com/Himel-HSTU/RegretBook",
    LiveDemoUrl: null,
    IsFeaturedOnHome: true,
    HasPlaceholderNotice: true
),


new(
    Slug: "hstu-clubbees",
    Title: "HSTU Clubbees",
    Tagline: "A centralized platform for campus club discovery, event management, and student engagement at HSTU.",
    Category: "Campus Platform / Full-Stack",
    Status: ProjectStatus.InProgress,

    ShortDescription: "A centralized campus platform designed to connect students with clubs and organizations at Hajee Mohammad Danesh Science and Technology University (HSTU), making it easier to discover clubs, explore activities, and stay updated on campus events.",

    ProblemStatement: "Information about university clubs, recruitment drives, events, and workshops is often scattered across different social media pages and groups. This makes it difficult for students to discover organizations, keep track of activities, and stay connected with campus communities.",

    Motivation: "Inspired by the lively movement of bees around campus clubs, HSTU Clubbees aims to bring the university's club ecosystem together in one place. The idea is to make campus communities easier to discover, explore, and engage with through a shared digital platform.",

    ProposedSolution: "A centralized platform featuring a directory of university clubs, club profiles, event announcements, recruitment information, and dedicated management capabilities for club administrators. Students can explore campus organizations and keep track of their activities from one place.",

    ArchitectureOverview: "A modular backend application built with C# and ASP.NET Core, following a structured API-based architecture. The system is designed around relational data modeling, role-based authorization, and separate management capabilities for students, club administrators, and platform administrators.",

    TechStack:
    [
        "C#",
        "ASP.NET Core",
        "Entity Framework Core",
        "PostgreSQL / SQL Server",
        "REST API",
        "JWT Authentication",
        "Angular / Blazor"
    ],

    EngineeringDecisions:
    [
        "Plan role-based access control to distinguish students, club administrators, and platform administrators.",
        "Structure club, membership, event, and recruitment data through relational database modeling.",
        "Design modular API endpoints to keep club management, event management, and student-facing features organized."
    ],

    Challenges:
    [
        "[To be documented] Record actual technical challenges encountered while designing club hierarchies, permissions, and recruitment workflows."
    ],

    FutureImprovements:
    [
        "Automated notifications and reminders for upcoming events and recruitment deadlines.",
        "Digital certificate verification and member participation history.",
        "Advanced club discovery and activity filtering."
    ],

    GitHubUrl: GitHubUrl,
    LiveDemoUrl: null,
    IsFeaturedOnHome: true,
    HasPlaceholderNotice: true
),


new(
    Slug: "hstu-alumnibook",
    Title: "HSTU AlumniBook",
    Tagline: "Connecting HSTU Alumni, Students, and Opportunities Through a Unified Network.",
    Category: "Directory & Professional Networking Platform",
    Status: ProjectStatus.Planned,

    ShortDescription: "A university-focused alumni networking platform designed to connect HSTU graduates with current students, helping them discover professional journeys, explore career paths, and build meaningful academic and professional connections.",

    ProblemStatement: "Current students often have limited access to a structured network of university alumni. Finding graduates based on their department, graduation batch, professional experience, or industry can be difficult, limiting opportunities for mentorship, career guidance, and professional networking.",

    Motivation: "Inspired by the value of alumni connections and the importance of learning from those who have already navigated similar academic and career paths. HSTU AlumniBook aims to bridge the gap between current students and graduates by bringing the university's alumni community into one accessible network.",

    ProposedSolution: "A centralized alumni directory where users can explore verified graduate profiles through filters such as department, graduation batch, company, and professional domain. The platform aims to support professional networking, mentorship connections, and career exploration between alumni and current students.",

    ArchitectureOverview: "Planned as a full-stack web application with an ASP.NET Core Web API backend and a modern frontend. The backend will follow a modular architecture with relational data modeling, profile management, search and filtering capabilities, and role-based access control. Alumni verification and privacy-aware contact workflows will be important parts of the system design.",

    TechStack:
    [
        "C#",
        "ASP.NET Core Web API",
        "Entity Framework Core",
        "SQL Server",
        "REST API",
        "React / Blazor"
    ],

    EngineeringDecisions:
    [
        "Plan multi-criteria search and filtering across graduation batch, department, company, and professional domain.",
        "Separate public alumni profile information from private contact details through privacy-aware access controls.",
        "Design an alumni verification workflow to maintain the credibility of professional profiles."
    ],

    Challenges:
    [
        "[To be documented] Explore reliable alumni verification and profile onboarding workflows.",
        "[To be documented] Design efficient filtering and search across a growing alumni directory."
    ],

    FutureImprovements:
    [
        "AI-assisted alumni and mentor matching based on career interests and professional backgrounds.",
        "Job and internship opportunity board for HSTU students.",
        "Alumni-led mentorship programs and professional community groups.",
        "Alumni achievements and career journey highlights."
    ],

    GitHubUrl: GitHubUrl,
    LiveDemoUrl: null,
    IsFeaturedOnHome: true,
    HasPlaceholderNotice: true
),

    ];

    // =========================================================================
    // 06. COMPETITIVE PROGRAMMING PROFILES
    // =========================================================================
    public static readonly IReadOnlyList<CpPlatformProfile> CpProfiles =
    [
        new(
            PlatformName: "Codeforces",
            HandlePlaceholder: "0xBASE_11",
            ProfileUrl: "https://codeforces.com/profile/0xBASE_11",
            SolvedCountDisplay: "500+",
            CurrentRatingDisplay: "1060",
            MaxRatingDisplay: "Newbie · 1126",
            RankTitleDisplay: "Competitive Programmer (C++ / STL / DSA)",
            Notes: "Dreaming of the legendary Tourist title, though I know that's a luxury to achieve. Still learning, still struggling, and still hoping to reach somewhere I believe I deserve to be."
        ),
        new(
            PlatformName: "LeetCode",
            HandlePlaceholder: "Himel_HSTU",
            ProfileUrl: "https://leetcode.com/Himel_HSTU/",
            SolvedCountDisplay: "50+",
            CurrentRatingDisplay: "Data Structures & Algorithms",
            MaxRatingDisplay: "Interview & DSA",
            RankTitleDisplay: "Algorithmic Problem Solver",
            Notes: "Exploring data structures and algorithms through structured problem-solving, focusing on efficient solutions, coding patterns, and algorithmic optimization."
        ),
        new(
            PlatformName: "CodeChef",
            HandlePlaceholder: "himelr27",
            ProfileUrl: "https://www.codechef.com/users/himelr27",
            SolvedCountDisplay: "50+",
            CurrentRatingDisplay: "[EDITABLE: Rating]",
            MaxRatingDisplay: "1 Star · 1385",
            RankTitleDisplay: "Division Participant",
            Notes: "Participating in timed programming contests and tackling algorithmic challenges to improve problem-solving speed, accuracy, and logical thinking."
        ),
        new(
            PlatformName: "AtCoder",
            HandlePlaceholder: "Himel_HSTU",
            ProfileUrl: "https://atcoder.jp/users/Himel_HSTU",
            SolvedCountDisplay: "30+",
            CurrentRatingDisplay: "[EDITABLE: Rating]",
            MaxRatingDisplay: "Will Update Soon",
            RankTitleDisplay: "Beginner / Regular Contests",
            Notes: "Mathematical problem solving and clean C++ implementation."
        )
    ];

    // =========================================================================
    // 07. ICPC / IUPC COMPETITION JOURNEY
    // =========================================================================
    public static readonly IReadOnlyList<ContestEntry> ContestJourney =
    [
        new(
            ContestName: "3x ICPC Asia Dhaka Regional Preliminary Contest",
            Category: "ICPC Preliminary",
            DateDisplay: "2026, 2025, 2024",
            TeamName: "HSTU_1MAANxUnit",
            ParticipationStage: "Official Preliminary Participation",
            ResultOrStandingDisplay: "Top 35%",
            KeyTakeaway: "Collaborated under strict contest time constraints representing HSTU, focusing on rapid problem triage, C++ STL implementation, and edge-case debugging."
        ),
        new(
            ContestName: "bKash presents SUST CSE Carnival 2026 – IUPC",
            Category: "IUPC",
            DateDisplay: "July, 2026",
            TeamName: "HSTU_1MAANxUnit",
            ParticipationStage: "Participated",
            ResultOrStandingDisplay: "106th / 142 Teams",
            KeyTakeaway: "A valuable contest experience, testing our teamwork, problem-solving abilities, and composure under competitive pressure."
        ),
        new(
           ContestName: "Rangpur Divisional Collegiate Programming Contest (RDCPC 2025) – HSTU CSE Fest",
           Category: "IUPC",
         DateDisplay: "June 2025",
    TeamName: "HSTU_1MAANxUnit",
    ParticipationStage: "Participated",
    ResultOrStandingDisplay: "14th / 25 Teams",
    KeyTakeaway: "A valuable opportunity to compete with teams across the division, strengthen collaborative problem-solving, and gain experience in a competitive programming environment."
)

    ];

    // =========================================================================
    // 08. UNIVERSITY CLUBS & EXTRACURRICULAR ACTIVITIES
    // =========================================================================
    public static readonly IReadOnlyList<ClubActivityEntry> ClubActivities =
    [
        new(
    OrganizationName: "Programmers Arena",
    Role: "Seminar & Workshop Secretary | Executive Member",
    Period: "2024 – Present",
    Summary: "A university programming community promoting competitive programming, algorithmic problem-solving, and peer learning at HSTU.",
    ResponsibilitiesAndActivities:
    [
        "Introduce Competitive Programming to junior batches through programming classes, practice sessions, and mentorship.",
        "Conduct programming contests for junior students to encourage problem-solving and Competitive Programming participation.",
        "Contribute to organizing major university events, including the National High School Programming Contest (NHSPC 2025 & 2026) and various university coding festivals.",
        "Organize technical seminars, workshops, and club engagement activities to promote knowledge sharing and student participation."
    ]
),
        new(
    OrganizationName: "ECE Club of HSTU",
    Role: "Former IT Secretary & Programmers Wing",
    Period: "2024 - 2026",
    Summary: "The departmental club of Electronics and Communication Engineering at HSTU, fostering technical learning, creativity, and student engagement through various academic and extracurricular activities.",
    ResponsibilitiesAndActivities:
    [
        "\"Unexpected tasks, impossible deadlines, and the classic 'Need it ASAP!' — regardless of where you are or whether you have an exam tomorrow. A good crash course in adaptability, prioritization, and getting things done under pressure.\"",
        "Designed promotional graphics, event banners, and visual materials for departmental programs, seminars, workshops, and tournaments.",
        "Introduced competitive programming to ECE junior batches through programming classes, guided practice sessions, and mentorship.",
        "Organized internal programming contests, technical seminars, and workshops to encourage programming interest and technical engagement among juniors."
    ]
)
    ];

    // =========================================================================
    // 09. pcBhai BRAND DATA (EXACT CASING: pcBhai)
    // =========================================================================
    public const string PcBhaiHeadline = "BEYOND CODING, THE TECH ENTHUSIAST IN ME";
    public const string PcBhaiTagline = "Custom PC Building, Hardware Reviews & Buying Guides in Bangladesh.";
    public const string PcBhaiSubscribersStat = "6,000+";
    public const string PcBhaiVideosStat = "150+";
    public const string PcBhaiBuildsDeliveredStat = "100+";

    public const string PcBhaiStoryOverview =
        "pcBhai is a technology content brand and custom PC-building small venture founded to help students, gamers, and professionals in Bangladesh make informed hardware decisions. From budget pc component breakdowns and full customize pc build guides,used component buying inspection checklists to assembling and shipping 100+ custom desktop PCs across Bangladesh, pcBhai combines hands-on hardware & software expertise with transparent tech education.";

    public static readonly IReadOnlyList<PcBhaiVideoItem> PcBhaiVideos =
    [
        new(
            Title: "Under 50K Ultimate AMD Ryzen 5 8600G PC Build BD 2025 : All Rounder PC (FUTURE-PROOF)",
            Category: "PC Build Guide",
            YouTubeVideoId: "GJMdJYLu3RM",
            DurationDisplay: "23:04",
            Summary: " In this video,we will briefly discuss about Under 50K Best Budget Gaming & Productivity PC Build in Bangladesh 2025 with AMD Ryzen 5 8600G,MSI A620M-E Motherboard,G.Skill Trident Z5 Neo RGB 16GB DDR5 6000Mhz Ram,512GB Gen 3 NVMe SSD,Antec Meta 550W,Monarch Mystery Box X5 ARGB mATX Gaming Casing.",
            IsFeatured: true
        ),
        new(
            Title: "মাত্র ৩ হাজার টাকায় Monarch Ice Cooler X5 Gaming Casing",
            Category: "Unboxing & Review",
            YouTubeVideoId: "lCWnF-Vdf_k",
            DurationDisplay: "16:07",
            Summary: "In This Video,We will unbox and share a brief overview of Monarch Ice Cooler X5 ARGB Desktop Gaming Case comes with 5 ARGB Fan that can be controlled by Motherboard at Just 3100-3200 Taka in Bangladesh.",
            IsFeatured: true
        ),
        new(
            Title: "Save Money on Your New PC Build | All PC Components Buying Guide 2026 (New vs Used) ?",
            Category: "PC Build Guide",
            YouTubeVideoId: "eGMGBYXY-FQ",
            DurationDisplay: "49:04",
            Summary: "In this video, we will discuss how to save money while building a new PC in the current market, which components should be bought brand new, which parts can be considered used for better value, and how to balance performance with budget. We’ll also share practical tips, common buying mistakes to avoid, and smart decisions that can help you build the best possible PC within your budget in Bangladesh.",
            IsFeatured: true
        ),
        new(
            Title: "75K Ultimate PC Build Guide: Gaming & Productivity with Ryzen 5 5600 & Intel Arc A750 8GB GPU.",
            Category: "PC Build Guide",
            YouTubeVideoId: "f1DV-pAgi6I",
            DurationDisplay: "24:32",
            Summary: "In this video,we will briefly discuss about Under 75K Best Budget Gaming & Productivity Fully FUTURE-PROOF PC Build in Bangladesh 2024 with AMD Ryzen 5 5600X/5600,B550M Motherboard,Intel Arc A750 8GB Gaming + Productivity GPU n So On.",
            IsFeatured: false
        ),
        new(
            Title: "মাত্র ১০,৫০০ টাকায় Samsung LS22D300GAW: The Perfect Budget 100Hz 22-Inch Monitor We Deserve?",
            Category: "Monitors",
            YouTubeVideoId: "6vtTmaawZpM",
            DurationDisplay: "15:10",
            Summary: "In this video,We will unbox and share a brief overview of best budget 100Hz 5ms 22 Inch Gaming+Editing Monitor in Just 10K BDT - Samsung LS22D300GAW.",
            IsFeatured: false
        ),
        new(
            Title: "Under 70K Full PC Build Guide 2025 | Ft.AMD Ryzen 7 7700,16GB DDR5,1TB Gen 4 NVMe (FUTURE PROOF PC).",
            Category: "PC Build Guide",
            YouTubeVideoId: "mOVonkrVS4k",
            DurationDisplay: "25:27",
            Summary: " In this video,we will briefly discuss about Under 65K Best Budget Gaming & Productivity Fully \"FUTURE-PROOF\" PC Build in Bangladesh 2025 with AMD Ryzen 7 7700,MSI PRO B650M-P DDR5 Motherboard,G.Skill Trident Z5 Neo RGB 16GB DDR5 6000Mhz Gaming RAM,Kingston FURY Renegade Gen 4 1TB NVMe,Corsair CX550W PSU,PC Power Sea View V2 PG-H35 BK ATX Gaming Casing,Samsung LS22D300GAW 21.5\" 100Hz FHD IPS Monitor.",
            IsFeatured: false
        )
    ];

    public static readonly IReadOnlyList<PcBuildShowcaseItem> PcBuildsGallery =
    [
        new(
            BuildTitle: "Workstation & Coding Desktop Build",
            TierCategory: "Software Engineering / Productivity",
            ProcessorAndGpu: "Multi-core CPU + High-Speed NVMe + Dual-Monitor Setup",
            PurposeSummary: "Configured for heavy IDE compilation, dual-boot Linux/Windows workflows, and silent thermal operation.",
            LocationDelivered: "Delivered in Bangladesh"
        ),
        new(
            BuildTitle: "1080p High-Refresh Gaming & Streaming Rig",
            TierCategory: "Custom Gaming Build",
            ProcessorAndGpu: "Balanced CPU/GPU Pair + High-Airflow ATX Mesh Chassis",
            PurposeSummary: "Built and stress-tested for sustained frame pacing, clean cable management, and upgrade longevity.",
            LocationDelivered: "Delivered Nationwide"
        ),
        new(
            BuildTitle: "Student Budget APU Build",
            TierCategory: "Value Academic Build",
            ProcessorAndGpu: "Integrated Graphics APU + Fast Dual-Channel DDR4/DDR5",
            PurposeSummary: "Optimized for university students needing maximum reliability on a tight budget with a clear future GPU upgrade path.",
            LocationDelivered: "Delivered in Bangladesh"
        )
    ];

    // =========================================================================
    // 10. CURRENTLY EXPLORING FOCUS AREAS
    // =========================================================================
    public static readonly IReadOnlyList<(string Title, string Category, string Summary)> ExploringFocusAreas =
[
    (".NET & Backend Engineering", "Core Engineering",
        "Exploring ASP.NET Core, MVC, Web APIs, databases, and the practices behind building reliable backend systems."),

    ("System Design & Software Architecture", "Engineering Concepts",
        "Learning about system design, software architecture, SDLC, and how software evolves from an idea into a working system."),

    ("Artificial Intelligence & Machine Learning", "Emerging Technologies",
        "Curious about AI, machine learning, LLMs, and how intelligent technologies can become part of everyday software."),

    ("Frontend Technologies & UI Engineering", "Creative Exploration",
        "Always curious to explore the frontend world — Angular, React, Blazor, Vue, and everything in between."),

    ("Small Business & Practical Ventures", "Beyond Engineering",
        "Interested in building and running a small business around the things I know, am good at, enjoy, and can create."),

    ("Entrepreneurship & Software Ventures", "Entrepreneur Worm",
        "A childhood dream that never left — building something of my own, turning ideas into products, and someday starting a software venture.")
];

    // =========================================================================
    // 11. TECHNICAL BLOG ARTICLES (CLEARLY LABELLED DRAFTS)
    // =========================================================================
    public static readonly IReadOnlyList<BlogArticleItem> BlogArticles =
    [

new(
    Slug: "why-i-still-choose-software-engineering-in-the-age-of-ai",
    Title: "Why I Still Choose Software Engineering in the Age of AI",
    Category: "Software Engineering / Personal Reflections",
    PublishedDate: "November 2026",
    ReadingTime: "7 min read",
    IsDraftPlaceholder: false,

    Excerpt: "From a childhood dream of becoming a Software Architect to navigating an industry being reshaped by AI. A personal reflection on uncertainty, curiosity, learning, and why I still choose Software Engineering.",

    Tags:
    [
        "Software Engineering",
        "Artificial Intelligence",
        "Career Journey",
        ".NET",
        "Learning in Public"
    ],

    TableOfContents:
    [
        "A Dream Since Class Eight",
        "The Uncertainty of an Evolving Industry",
        "A Small Experiment That Changed My Perspective",
        "From Visualizing Ideas to Building Them",
        "Preparing for Whatever Comes Next"
    ],

    Paragraphs:
    [
        "In simple words, I love Software Engineering. I don't know exactly why, but since Class 8, I've had only one dream: to become a good Software Engineer. Maybe Junior, then Mid, Senior, and eventually Software Architect. That's how I imagine starting and ending my career.",

        "Whenever I learn something new, work through a problem, debug for hours, or finally solve something frustrating, there's a different kind of smile and inner peace that comes with it. That feeling is probably the biggest reason I still love doing this.",

        "But when it comes to pursuing that dream, the industry seems to be changing rapidly. One of the biggest forces behind that change is Artificial Intelligence and Machine Learning. As someone who will soon enter the job market, I sometimes find myself questioning what the future of Software Engineering will look like.",

        "Sitting in my room, I'm usually optimistic about my future. Then come the market realities, industry discussions, posts, and suggestions from seniors. Suddenly, things don't feel quite as certain. Sometimes, these conversations make me uncomfortable and push me to rethink my decisions. I guess that's a natural feeling when you're getting closer to entering an industry that's evolving so quickly.",

        "Let me share a small story from one particular night.",

        "I was working on a .NET Web API + Next.js project, building and testing the APIs. Being curious, I always had frontend ideas running through my mind. But I had made a promise to myself: first complete the backend and database, then build a basic frontend. Nothing fancy.",

        "After four or five hours of backend work, it was finally time for dinner and sleep. But then I thought, why not spend just five minutes visualizing what was running through my mind?",

        "I considered sketching it on paper and even thought about opening Figma. But I didn't have much time. So I opened Photoshop instead, put together what was probably one of the worst design visualizations in the universe 😂, and decided to give it to ChatGPT or Gemini with a prompt to see what would happen.",

        "Loading... Waiting... Waiting...",

        "And then suddenly, an image appeared. Exactly what I had been imagining. Simple. Minimal. Beautiful. ✨",

        "Honestly, GPT generated something a thousand times better than I had expected. Something I probably wouldn't have been able to visualize or implement on my own at that point.",

        "From one of my worst visualizations to one of the finest implementations.",

        "I know these tools are meant to be our companions, helping us work faster, explore ideas, and overcome limitations. But that tiny experience made me realize just how many possibilities AI is opening up. Sometimes I even feel a little jealous. How are they this good? Even their imperfections sometimes look better than my perfection, I guess. 😐",

        "Still, I believe that even if the market becomes more challenging, opportunities will continue to exist for capable engineers. The expectations may change, the tools may evolve, and the way we work may look completely different. But I want to be prepared to adapt.",

        "I'll learn whatever I need: MVC, Web API, MAUI, Razor Pages, Blazor, React, Angular, Vue, System Design, SDLC, Cloud, AI/ML... 🙃 I know learning everything is impossible. And perhaps trying to learn everything isn't even the right approach. But I want to keep exploring, strengthening my fundamentals, and building things that actually work.",

        "There's one promise I always make to myself: if the market has only ONE recruitment opportunity for a Software Engineer, I want to be the one prepared enough to grab it.",

        "Learning. Building. Grinding. The rest is in the hands of Almighty Allah. 🚀"
    ]
),

new(
    Slug: "my-competitive-programming-journey",
    Title: "Rediscovering Competitive Programming: A Journey of Persistence and Growth",
    Category: "Competitive Programming / Personal Journey",
    PublishedDate: "November 2026",
    ReadingTime: "6 min read",
    IsDraftPlaceholder: false,

    Excerpt: "From my first exposure to programming contests in Class 8 to competing at university, this is the story of rediscovering my passion for Competitive Programming, learning through contests, and continuing to push my limits.",

    Tags:
    [
        "Competitive Programming",
        "Problem Solving",
        "ICPC",
        "Programming Contests",
        "Personal Journey"
    ],

    TableOfContents:
    [
        "Where It All Started",
        "The Years Away from Competitive Programming",
        "A New Beginning at University",
        "Learning Through Contests",
        "The Journey Continues"
    ],

    Paragraphs:
    [
        "Being curious has always been a part of my journey with technology. My introduction to Competitive Programming dates back to 2018, when I was in Class 8. It was probably through the National High School Programming Contest (NHSPC) 2018 that I first got exposed to the world of programming competitions.",

        "However, I didn't continue after that. Perhaps academic pressure, a lack of direction, or simply not having the right motivation kept me away. But somewhere deep down, my interest in programming and problem-solving never really disappeared.",

        "During those years, my primary academic goal was to get admitted to a reputed public university in a subject I was passionate about, preferably CSE, EEE, or ECE. Alongside my studies, I kept exploring different areas of technology, including Software Development, Web Development, Game Development, and emerging technologies.",

        "I was also running my YouTube channel, pcBhai, where I shared content about custom-built PCs, hardware, and technology. These experiences helped me explore different sides of the tech world, even while Competitive Programming remained something I wanted to return to.",

        "Eventually, I got admitted to the Department of Electronics and Communication Engineering (ECE) at Hajee Mohammad Danesh Science and Technology University (HSTU). University life gave me a fresh opportunity to reconnect with the interest I had left behind years earlier.",

        "With renewed motivation, I started participating in programming contests, just as I had always planned. Being part of the university's programming community and getting involved with Programmers Arena helped me take that first step seriously.",

        "Since then, I have participated in more than 20 offline programming contests, both individually and as part of a team, organized through the university's programming community. I also participated in the ICPC Online Preliminary Round 2024, gaining exposure to a more competitive programming environment.",

        "Of course, the journey hasn't been all about achievements. Competing against talented problem solvers is challenging, and I haven't always achieved the rankings I hoped for. My performances have often been around the top 30–50% of participants. But every contest has taught me something new.",

        "Some problems taught me to think differently. Others exposed gaps in my mathematical knowledge, implementation skills, or problem-solving approach. There were contests where I performed better than expected and others where I realized just how much I still needed to learn.",

        "Over time, I have come to understand that Competitive Programming is not simply about solving as many problems as possible or achieving a particular rating. It is also about developing patience, logical thinking, consistency, and the ability to approach unfamiliar problems under pressure.",

        "Success doesn't come overnight. Every contest, every accepted submission, and even every unsuccessful attempt contributes to the learning process. I still have a long way to go, and there are plenty of concepts I want to explore and master.",

        "For now, the goal is simple: keep learning, keep participating, and keep improving. I look forward to taking on bigger challenges, becoming a stronger problem solver, and seeing how far this journey takes me.",

        "Thank you to everyone who has been part of this journey and continues to make the programming community at HSTU a place to learn and grow.",

        "The journey continues. ✨"
    ],

    CodeSampleCSharp: null
),

new(
    Slug: "beyond-coding-my-journey-with-pcbhai",
    Title: "Beyond Coding: Turning a Passion for Technology into Something Real",
    Category: "Technology / Entrepreneurship / Personal Journey",
    PublishedDate: "November 2026",
    ReadingTime: "8 min read",
    IsDraftPlaceholder: false,

    Excerpt: "From a childhood fascination with computers and gadgets to building a tech-focused YouTube community and serving custom PC customers across Bangladesh. A personal journey of turning curiosity into something meaningful beyond the classroom.",

    Tags:
    [
        "pcBhai",
        "Technology",
        "Custom PC Building",
        "Tech Content Creation",
        "Entrepreneurship",
        "Personal Journey"
    ],

    TableOfContents:
    [
        "A Childhood Fascination with Technology",
        "From a YouTube Hobby to a Community",
        "Building Custom PCs Across Bangladesh",
        "Lessons Beyond Hardware",
        "Making Room for Long-Term Goals"
    ],

    Paragraphs:
    [
        "From a young age, I've always been fascinated by computers, electronic gadgets, and the technology behind them. That curiosity eventually led me to pursue Electronics and Communication Engineering at university. Alongside my academic journey, I've continued exploring technology, practicing Competitive Programming, and working toward my long-term goal of becoming a Software Engineer.",

        "But my journey with technology has never been limited to programming or academics.",

        "My growing interest in computers, laptops, and PC hardware inspired me to start a YouTube channel called pcBhai almost five years ago. What began as a hobby gradually turned into a platform where I could share knowledge about PC components, review hardware, discuss buying decisions, and suggest custom PC configurations for different budgets and requirements.",

        "Over time, something that started as a personal interest grew into a small but genuine community of people who shared the same enthusiasm for technology. Seeing people engage with the content, ask questions, and trust my recommendations made the experience even more meaningful.",

        "As the channel grew, I started receiving requests from people interested in building custom PCs. Eventually, I began helping customers select components, source hardware, assemble systems, and get their PCs delivered.",

        "What makes this experience particularly special is that I've had the opportunity to serve customers across different cities in Bangladesh, including Dhaka, Chittagong, Cumilla, Sylhet, Rajshahi, Barishal, Bogura, Mymensingh, Rangpur, Faridpur, Dinajpur, and many others.",

        "My approach has been to source components directly from official importers and trusted third-party shops, carefully select compatible hardware, personally assemble and test the systems, and coordinate delivery. I also provide after-sales support to help customers with their questions and technical issues.",

        "Within the first 9–10 months of actively handling custom PC orders, I successfully processed more than 50 orders. Alhamdulillah. ✨ For me, this was more than just selling computer components. It was an opportunity to turn something I genuinely loved into a real-world experience.",

        "Of course, it wasn't always easy. Building customer trust, managing orders, determining fair pricing, maintaining consistent quality, and handling logistics all came with their own challenges.",

        "Perhaps the biggest challenge was convincing people to trust someone they had never met, especially when most of the business was handled remotely. Being based in Dinajpur rather than a major commercial hub made that trust-building process even more important.",

        "I also had to learn how to communicate with people from different cities, understand their individual requirements, manage expectations, and handle situations where technical preferences and budgets didn't always align. These experiences taught me lessons that I probably wouldn't have learned from a classroom alone.",

        "Beyond hardware knowledge, I gradually developed practical skills in customer communication, negotiation, organization, pricing, logistics, and problem-solving. Most importantly, I learned how much trust and communication matter when you're trying to build something of your own.",

        "However, as much as I love this journey, I also understand that I cannot give it the same amount of attention forever. My long-term goal has always been to build a career in the Software Engineering and IT industry. With university studies, Competitive Programming, and my growing focus on .NET and emerging technologies, I need to make deliberate decisions about where my time and energy go.",

        "That's why I've gradually started reducing the number of custom PC orders I accept and slowing down content creation on YouTube. I don't want to abandon pcBhai or the community I've built. Instead, I want to keep it alive while giving more attention to the career path I've been working toward for years.",

        "Looking back, pcBhai has given me much more than an opportunity to explore PC hardware. It has allowed me to create something independently, interact with people across the country, solve real-world problems, and experience the responsibilities of running a small business.",

        "Whatever direction my professional journey takes, I believe these experiences will remain an important part of who I am as an engineer and as a person.",

        "Sometimes, the most valuable lessons come from building something outside the path you originally planned.",

        "And this is one journey I'm genuinely grateful for. Alhamdulillah. 🚀"
    ],

    CodeSampleCSharp: null
)


    ];

    public static string ProfileImagePath => _profileImagePath;
}