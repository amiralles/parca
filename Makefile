build: ./src/**/*.cs
	mkdir -p ./bin
	mcs ./src/core/*.cs /target:library /out:./bin/parca.dll
	if [ -a ./src/tests/*.cs ]; then \
		mcs ./src/tests/*.cs /target:library /out:./bin/parcatests.dll \
		/r:./lib/Contest.Core.dll \
		/r:./bin/parca.dll; \
	fi;

dbgbuild: ./src/**/*.cs
	mkdir -p ./bin
	mcs ./src/core/*.cs /target:library /out:./bin/parca.dll
	if [ -a ./src/tests/*.cs ]; then \
		mcs ./src/tests/*.cs /target:library /out:./bin/parcatests.dll \
		/define:DEBUG \
		/r:./lib/Contest.Core.dll \
		/r:./bin/parca.dll; \
	fi;

test:
	mono ./lib/contest.exe run -nh ./bin/parcatests.dll
